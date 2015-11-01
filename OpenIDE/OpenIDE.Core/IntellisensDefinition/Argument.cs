using System.Windows.Markup;

namespace OpenIDE.Core.IntellisensDefinition
{
    [ContentProperty("Description")]
    public class Argument : IDefinitionItem
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}