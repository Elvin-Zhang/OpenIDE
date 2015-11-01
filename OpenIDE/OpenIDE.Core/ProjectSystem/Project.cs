using System;
using System.ComponentModel;
using System.Windows.Markup;
using System.Xaml;

namespace OpenIDE.Core.ProjectSystem
{
    [ContentProperty("Files")]
    public class Project
    {
        public string Name { get; set; }
        public FileCollection Files { get; set; }
        public Guid Type { get; set; }

        [DefaultValue(false)]
        public bool Expandet { get; set; }

        public Project()
        {
            Files = new FileCollection();
        }

        public void Save(string filename)
        {
            XamlServices.Save(filename, this);
        }

        public static Project Load(string filename)
        {
            return (Project)XamlServices.Load(filename);
        }
    }
}