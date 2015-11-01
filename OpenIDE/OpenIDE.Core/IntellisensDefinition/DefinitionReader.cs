using System.Xaml;

namespace OpenIDE.Core.IntellisensDefinition
{
    public class DefinitionReaderWriter
    {
        public static Definition Read(string src)
        {
            return XamlServices.Parse(src) as Definition;
        }

        public static string Write(Definition d)
        {
            return XamlServices.Save(d);
        }
    }
}