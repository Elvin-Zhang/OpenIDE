using System.Windows.Markup;

namespace OpenIDE.Core.IntellisensDefinition
{
    [ContentProperty("Items")]
    public class Method : IDefinitionItem
    {
        public string Name { get; set; }
        public ItemCollection Items { get; set; }

        public Method()
        {
            Items = new ItemCollection();
        }
    }
}