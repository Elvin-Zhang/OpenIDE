using OpenIDE.Core.Contracts;
using System;
using System.Drawing;

namespace OpenIDE.Core.Extensibility
{
    public class ItemTemplate
    {
        public string Name { get; set; }
        public Guid ID { get; set; }
        public string Highlighting { get; set; }
        public Image Icon { get; set; }
        public Guid ProjectID { get; set; }
        public string Extension { get; set; }
        public View View { get; internal set; }
        public byte[] Raw { get; set; }

        public ItemTemplate()
        {
            Name = "";
            ID = Guid.Empty;
        }
    }
}