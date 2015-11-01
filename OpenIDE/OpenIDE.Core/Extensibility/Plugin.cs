using Creek.Scripting;
using DigitalRune.Windows.TextEditor.Highlighting;
using Ionic.Zip;
using Microsoft.ClearScript;
using Microsoft.ClearScript.Windows;
using OpenIDE.Core.Contracts;
using OpenIDE.Core.JSON;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;

namespace OpenIDE.Core.Extensibility
{
    public class Plugin : IDisposable
    {
        public Dictionary<string, Image> Icons { get; set; }
        public List<ItemTemplate> ItemTemplates { get; set; }
        public List<ProjectTemplate> ProjectTemplates { get; set; }
        public IDictionary<string, object> Info { get; set; }
        private Dictionary<string, string> Highlightings;
        public PropertyStorage Properties = new PropertyStorage();
        public List<Library> Dependencies { get; set; }
        public WindowCollection Windows { get; set; }

        public string Language { get; set; }
        public string Filename { get; set; }
        public EventStorage Events { get; set; }

        public delegate object StaticMethodFunc(params object[] args);

        internal WindowsScriptEngine _engine;

        private Plugin()
        {            
            Icons = new Dictionary<string, Image>();
            ItemTemplates = new List<ItemTemplate>();
            ProjectTemplates = new List<ProjectTemplate>();

            Highlightings = new Dictionary<string, string>();
            Dependencies = new List<Library>();

            Events = new EventStorage();
            Windows = new WindowCollection();
        }

        private void InitEngine(ZipFile z)
        {
            _engine.Add("host", new ExtendedHostFunctions());

            // add function to script engine to control the properties
            _engine.Add<Delegate>("property", new StaticMethodFunc(args =>
            {
                if (args.Length == 1)
                {
                    return Properties.Get(args[0].ToString());
                }
                else if (args.Length == 2)
                {
                    Properties.Set(args[0].ToString(), args[1]);

                    return null;
                }

                return null;
            }));
            _engine.Add("require", new Action<string>(_ =>
            {
                var i = new StreamReader(z[_].OpenReader());

                _engine.Execute(i.ReadToEnd());
            }));
            _engine.Add("import", new Action<string>(_ =>
            {
                var l = Library.Load(_);
                l.Apply(_engine, Language);

                Dependencies.Add(l);
            }));

            _engine.Add("math", new OpenIDE.Library.Math());
            _engine.Add("JSON", new OpenIDE.Library.JSON());
            _engine.Add("XmlHttpRequest", typeof(OpenIDE.Library.XmlHttpRequest));
            _engine.Add("console", new OpenIDE.Library.Console.FirebugConsole());

            _engine.Add("argb", new Func<int, int, int, int, Color>((r, g, b, a) =>
            {
                return OpenIDE.Library.Functions.Argb(r, g, b, a);
            }));
            _engine.Add("hsla", new Func<double, double, double, int, Color>((h, s, l, a) =>
            {
                return OpenIDE.Library.Functions.Hsla(h, s, l, a);
            }));
            _engine.Add("hexadecimal", new Func<string, Color>(_ =>
            {
                return OpenIDE.Library.Functions.Hexadecimal(_);
            }));
            _engine.Add("register_window", new Action<string, Window>((n, w)=> Windows.Add(n, w)));
            _engine.Add("notify", new Action<string, string>((title, content) => 
                                    NotificationService.Notify(title, content)));
            _engine.Add("debug", Workspace.Output);

            _engine.Add("plugin", this);

            Events.Fire("OnReady");
        }

        public static Plugin Load(string name)
        {
            var p = new Plugin();

            var z = new ZipFile(name);
            var parts = z.Entries;
            var pa = parts.ToList();

            string props = "";

            for (int i = 0; i < pa.Count; i++)
            {
                var part = pa[i];

                if (part.FileName.StartsWith("Icons") && !part.IsDirectory)
                {
                    var strm = part.OpenReader();

                    var img = Image.FromStream(strm);
                    var n = part.FileName.Remove(0, "Icons/".Length);

                    p.Icons.Add(n, img);
                }
                if(part.FileName == "Sources/properties.js")
                {
                    var src = new StreamReader(z["Sources/properties.js"].OpenReader()).ReadToEnd();
                    props = src;
                }
                if (part.FileName == "info.json")
                {
                    var json = new StreamReader(part.OpenReader()).ReadToEnd();

                    p.Info = ((ObjectValue)Json.Parse(json)).Value;
                    p.Filename = name;
                }
            }

            p.ReadItemtemplates(z);

            if (p.Info.ContainsKey("Language"))
            {
                p.Language = p.Info["Language"].ToString();

                switch (p.Info["Language"].ToString())
                {
                    case "JavaScript":
                        p._engine = new JScriptEngine(WindowsScriptEngineFlags.EnableJITDebugging);
                        
                        break;
                    case "VBScript":
                        p._engine = new VBScriptEngine(WindowsScriptEngineFlags.EnableJITDebugging);

                        break;
                }
            }
            else
            {
                p._engine = new JScriptEngine(WindowsScriptEngineFlags.EnableJITDebugging);
                p.Language = "JavaScript";
            }

            p.InitEngine(z);
            p.ReadDependencies();

            p._engine.Execute(props);
            p._engine.Execute(new StreamReader(z["main.js"].OpenReader()).ReadToEnd());

            return p;
        }

        private void ReadDependencies()
        {
            if(Info.ContainsKey("Dependencies"))
            {
                var v = Info["Dependencies"] as ArrayValue;
                foreach (var item in v.Value)
                {
                    var l = Library.Load(item.ToString());
                    
                    l?.Apply(_engine, Language);

                    Dependencies.Add(l);
                }
            }
        }

        public void AddEventListener(string name, dynamic callback)
        {
            Events.AddListener(name, callback);
        }

        private void ReadItemtemplates(ZipFile z)
        {
            var t = Info["Templates"] as ObjectValue;
            var items = (t.Value["Item"] as ArrayValue).Value;

            foreach (var tt in items)
            {
                var obj = (tt as ObjectValue).Value;
                var te = new ItemTemplate();

                te.ProjectID = Guid.Parse(Info["ID"].ToString());

                te.Name = obj["Name"].ToString();
                te.Extension = obj["Extension"].ToString();
                te.ID = Guid.Parse(obj["ID"].ToString());

                var ms = new MemoryStream();
                z["Templates/Items/" + obj["Template"]].OpenReader().CopyTo(ms);

                te.Raw = ms.ToArray();

                if (Icons.Count > 0)
                {
                    te.Icon = Icons[obj["Icon"].ToString()];
                    SolutionExplorer.Icons.Add(te.ID, ResizeIcon(te.Icon, new Size(16, 16)));
                }

                if(obj.ContainsKey("View"))
                {
                    te.View = View.FromXaml(new StreamReader(z["Views/" + obj["View"]].OpenReader()).ReadToEnd());
                }

                var h = z["Highlighting/" + obj["Highlighting"].ToString()];
                te.Highlighting = obj["Highlighting"].ToString();

                HighlightingManager.Manager.AddSyntaxModeFileProvider(new StreamProvider(h.OpenReader()));

                ItemTemplates.Add(te);
            }
        }

        private Image ResizeIcon(Image image, Size size, bool preserveAspectRatio = true)
        {
            int newWidth;
            int newHeight;
            if (preserveAspectRatio)
            {
                int originalWidth = image.Width;
                int originalHeight = image.Height;
                float percentWidth = (float)size.Width / (float)originalWidth;
                float percentHeight = (float)size.Height / (float)originalHeight;
                float percent = percentHeight < percentWidth ? percentHeight : percentWidth;
                newWidth = (int)(originalWidth * percent);
                newHeight = (int)(originalHeight * percent);
            }
            else
            {
                newWidth = size.Width;
                newHeight = size.Height;
            }
            Image newImage = new Bitmap(newWidth, newHeight);
            using (Graphics graphicsHandle = Graphics.FromImage(newImage))
            {
                graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return newImage;
        }

        public void Dispose()
        {
            Dependencies = null;
            Filename = null;
            Highlightings = null;
            Icons = null;
            Info = null;
            ItemTemplates = null;
            Language = null;
            ProjectTemplates = null;
            Properties = null;
            _engine = null;
        }
    }
}