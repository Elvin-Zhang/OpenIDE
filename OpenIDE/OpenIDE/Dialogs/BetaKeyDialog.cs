using System;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace OpenIDE.Core.Dialogs
{
    public partial class BetaKeyDialog : RadForm
    {
        private RadForm _mainFrm;

        public BetaKeyDialog(RadForm mainFrm)
        {
            InitializeComponent();

            _mainFrm = mainFrm;
        }

        private void TranslateUI()
        {
            descriptionLabel.Text = LanguageManager._("Please enter your Beta-Key to try OpenDevelop:");

            okButton.Text = LanguageManager._("OK");
            cancelButton.Text = LanguageManager._("Cancel");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            var validator = new Validate();
            validator.Key = keyTextBox.Text;

            if(validator.IsValid)
            {
                if(validator.IsExpired)
                {
                    RadMessageBox.Show(LanguageManager._("Your Beta-Key is expired!!"));
                }
                else
                {
                    Workspace.Settings.Add("BetaAccepted", true);
                    _mainFrm.Show();
                    Hide();
                }
            }
            else
            {
                RadMessageBox.Show(LanguageManager._("Your Beta-Key is invalid!!"));
            }
        }
    }
}