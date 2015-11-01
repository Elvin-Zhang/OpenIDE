using OpenIDE.Core.ProjectSystem;
using OpenIDE.Core.Properties;
using OpenIDE.Core.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using Telerik.WinControls.UI;

namespace OpenIDE.Core
{
    public class SolutionExplorer
    {
        public static Dictionary<Guid, Image> Icons = new Dictionary<Guid, Image>();

        public static RadTreeNode Build(Project proj, RadContextMenu radContextMenu1)
        {
            var pn = new RadTreeNode($"Project '{proj.Name}'", true);
            pn.Tag = proj;
            pn.ContextMenu = radContextMenu1;

            var props = new RadTreeNode("Properties", Resources.Property, true);
            props.Tag = new PropertiesView();
            pn.Nodes.Add(props);

            pn.Expanded = proj.Expandet;

            foreach (var f in proj.Files)
            {
                var n = Build(f);

                pn.Nodes.Add(n);
            }

            return pn;
        }

        public static RadTreeNode Build(Solution sol, RadContextMenu radContextMenu1)
        {
            var ret = new RadTreeNode($"Solution '{sol.Name}'", true);
            ret.Tag = sol;

            foreach (var p in sol.Projects)
            {
                var pn = Build(p, radContextMenu1);

                ret.Nodes.Add(pn);
            }

            return ret;
        }

        public static RadTreeNode Build(File sol)
        {
            var n = new RadTreeNode(sol.Name);
            n.Tag = sol;

            n.Image = Icons[sol.ID];

            return n;
        }

    }
}