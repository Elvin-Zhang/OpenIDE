using OpenIDE.Core.Extensibility;
using System;
using Telerik.WinControls.UI;

namespace OpenIDE.Core.Dialogs
{
    public partial class NewItemDialog : RadForm
    {
        public Guid Type { get; set; }
        public string Filename { get; set; }
        public ItemTemplate Template { get; set; }
        public Plugin Plugin { get; set; }

        public NewItemDialog()
        {
            InitializeComponent();

            Filename = "";

            TranslateUI();

            foreach (var item in Workspace.PluginManager.Plugins)
            {
                foreach (var t in item.ItemTemplates)
                {
                    var i = new ListViewDataItem(t.Name);
                    i.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    i.Image = t.Icon;
                    i.Tag = t;
                    i.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
                    i.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

                    Plugin = item;

                    radListView1.Items.Add(i);
                }
            }

            radListView1.SelectedIndex = 0;
        }

        void TranslateUI()
        {
            Text = LanguageManager._("New Item");
            nameLabel.Text = LanguageManager._("Name");

            okButton.Text = LanguageManager._("OK");
            cancelButton.Text = LanguageManager._("Cancel");
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {
            Filename = radTextBox1.Text;
        }

        private void radListView1_SelectedItemChanged(object sender, EventArgs e)
        {
           var s = radListView1.SelectedItem?.Tag as ItemTemplate;

            if (s != null)
            {
                Type = s.ID;
                Template = s;

                if(!Filename.EndsWith(s.Extension))
                {
                    Filename += s.Extension;
                }
            }
        }
    }
}