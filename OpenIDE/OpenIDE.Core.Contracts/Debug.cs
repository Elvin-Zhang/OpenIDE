using System.Windows.Forms;

namespace OpenIDE.Core.Contracts
{
    public class Debug
    {
        private Control _c;

        public Debug(Control c)
        {
            _c = c;
        }

        public void Write(string src)
        {
            _c.Text += src;
        }

        public void WriteLine(string src)
        {
            _c.Text += "\r" + src;
        }
    }
}