using System.Windows.Markup;

namespace OpenIDE.Core.IntellisensDefinition
{
    [ContentProperty("Items")]
    public class Object : IDefinitionItem
    {
        public ItemCollection Items { get; set; }

        public Object()
        {
            Items = new ItemCollection();
        }
    }
}