using Telerik.WinControls.UI;

namespace OpenIDE.Core.Dialogs
{
    public partial class Pluginmanager : Telerik.WinControls.UI.RadForm
    {
        public Pluginmanager()
        {
            InitializeComponent();

            foreach (var p in Workspace.PluginManager.Plugins)
            {
                var item = new RadListDataItem();
                item.Text = p.Info["Name"].ToString();

                installedpluginsList.Items.Add(item);
            }
        }

        void TranslateUI()
        {
            Text = LanguageManager._("PluginManager");
            installedPluginsPage.Text = LanguageManager._("Installed Plugins");
            onlinePluginsPage.Text = LanguageManager._("Online Plugins");
        }
    }
}