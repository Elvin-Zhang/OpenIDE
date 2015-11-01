using System;

namespace OpenIDE.Core.Contracts
{
    public class Window
    {
        public string Title { get; set; }
        public Guid ID { get; set; }
        public ViewBuilder View { get; set; }
    }
}