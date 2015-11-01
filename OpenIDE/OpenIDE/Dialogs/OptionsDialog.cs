using OpenIDE.Core;

namespace OpenIDE.Dialogs
{
    public partial class OptionsDialog : GLib.Options.OptionsForm
    {
        public OptionsDialog()
        {
            InitializeComponent();

            TranslateUI();

            Panels.Add(new OptionsPages.GeneralOptionsPage());
        }

        void TranslateUI()
        {
            Text = LanguageManager._("Options");
        }
    }
}