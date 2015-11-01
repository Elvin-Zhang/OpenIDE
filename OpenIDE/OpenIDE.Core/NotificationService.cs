using Telerik.WinControls.UI;

namespace OpenIDE.Core
{
    public static class NotificationService
    {
        private static RadDesktopAlert _ctrl;

        public static void Init(RadDesktopAlert ctrl)
        {
            _ctrl = ctrl;
        }

        public static void Notify(string title, string content)
        {
            _ctrl.CaptionText = title;
            _ctrl.ContentText = content;

            _ctrl.Show();
        }
    }
}