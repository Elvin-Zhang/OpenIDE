using System.Windows.Markup;

namespace OpenIDE.Core.IntellisensDefinition
{
    [ContentProperty("Source")]
    public class Example : IDefinitionItem
    {
        public string Source { get; set; }
    }
}