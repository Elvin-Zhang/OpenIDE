using System;
using System.IO;
using System.Linq;

namespace OpenIDE.Core
{
    public static class Utils
    {
        public static Guid GetTemplateID(string src)
        {
            /*foreach (var p in Workspace.PluginManager.Plugins)
            {
                foreach (var it in p.ItemTemplates)
                {
                    if(it.Extension == Path.GetExtension(src))
                    {
                        return it.ID;
                    }
                }
            }*/

            return Workspace.PluginManager.Plugins.SelectMany(_ => _.ItemTemplates).
                Where(_ => _.Extension == Path.GetExtension(src)).Select(_ => _.ID).FirstOrDefault();
        } 
    }
}