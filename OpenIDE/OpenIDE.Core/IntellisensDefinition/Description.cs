using System.Windows.Markup;

namespace OpenIDE.Core.IntellisensDefinition
{
    [ContentProperty("Text")]
    public class Description : IDefinitionItem
    {
        public string Text { get; set; }
    }
}