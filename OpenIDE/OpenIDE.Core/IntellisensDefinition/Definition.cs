using System.Windows.Markup;

[assembly: XmlnsDefinition("http://furesoft.de/schema/Definition/2015", "OpenIDE.Core.IntellisensDefinition")]

namespace OpenIDE.Core.IntellisensDefinition
{
    [ContentProperty("Items")]
    public class Definition
    {
        public ItemCollection Items { get; set; }

        public Definition()
        {
            Items = new ItemCollection();
        }
    }
}