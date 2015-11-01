namespace OpenIDE.Core.Dialogs
{
    partial class Pluginmanager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new Telerik.WinControls.UI.RadPageView();
            this.installedPluginsPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.installedpluginsList = new Telerik.WinControls.UI.RadListControl();
            this.onlinePluginsPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.onlinepluginsList = new Telerik.WinControls.UI.RadListControl();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.installedPluginsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.installedpluginsList)).BeginInit();
            this.onlinePluginsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlinepluginsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.installedPluginsPage);
            this.tabControl.Controls.Add(this.onlinePluginsPage);
            this.tabControl.DefaultPage = this.installedPluginsPage;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedPage = this.installedPluginsPage;
            this.tabControl.Size = new System.Drawing.Size(919, 494);
            this.tabControl.TabIndex = 0;
            this.tabControl.Text = "Installed Plugins";
            this.tabControl.ThemeName = "VisualStudio2012Dark";
            this.tabControl.ViewMode = Telerik.WinControls.UI.PageViewMode.Backstage;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.tabControl.GetChildAt(0))).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Near;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.tabControl.GetChildAt(0))).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.FillHeight;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.tabControl.GetChildAt(0))).StripAlignment = Telerik.WinControls.UI.StripViewAlignment.Left;
            // 
            // installedPluginsPage
            // 
            this.installedPluginsPage.Controls.Add(this.installedpluginsList);
            this.installedPluginsPage.ItemSize = new System.Drawing.SizeF(95F, 26F);
            this.installedPluginsPage.Location = new System.Drawing.Point(205, 4);
            this.installedPluginsPage.Name = "installedPluginsPage";
            this.installedPluginsPage.Size = new System.Drawing.Size(710, 486);
            this.installedPluginsPage.Text = "Installed Plugins";
            // 
            // installedpluginsList
            // 
            this.installedpluginsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installedpluginsList.ItemHeight = 64;
            this.installedpluginsList.Location = new System.Drawing.Point(0, 0);
            this.installedpluginsList.Name = "installedpluginsList";
            this.installedpluginsList.Size = new System.Drawing.Size(710, 486);
            this.installedpluginsList.TabIndex = 0;
            this.installedpluginsList.Text = "radListControl1";
            this.installedpluginsList.ThemeName = "VisualStudio2012Dark";
            // 
            // onlinePluginsPage
            // 
            this.onlinePluginsPage.Controls.Add(this.onlinepluginsList);
            this.onlinePluginsPage.ItemSize = new System.Drawing.SizeF(95F, 26F);
            this.onlinePluginsPage.Location = new System.Drawing.Point(205, 4);
            this.onlinePluginsPage.Name = "onlinePluginsPage";
            this.onlinePluginsPage.Size = new System.Drawing.Size(710, 486);
            this.onlinePluginsPage.Text = "Online Plugins";
            // 
            // onlinepluginsList
            // 
            this.onlinepluginsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.onlinepluginsList.ItemHeight = 64;
            this.onlinepluginsList.Location = new System.Drawing.Point(0, 0);
            this.onlinepluginsList.Name = "onlinepluginsList";
            this.onlinepluginsList.Size = new System.Drawing.Size(710, 486);
            this.onlinepluginsList.TabIndex = 1;
            this.onlinepluginsList.Text = "radListControl1";
            this.onlinepluginsList.ThemeName = "VisualStudio2012Dark";
            // 
            // Pluginmanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 494);
            this.Controls.Add(this.tabControl);
            this.Name = "Pluginmanager";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "PluginManager";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.installedPluginsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.installedpluginsList)).EndInit();
            this.onlinePluginsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.onlinepluginsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView tabControl;
        private Telerik.WinControls.UI.RadPageViewPage installedPluginsPage;
        private Telerik.WinControls.UI.RadPageViewPage onlinePluginsPage;
        private Telerik.WinControls.UI.RadListControl installedpluginsList;
        private Telerik.WinControls.UI.RadListControl onlinepluginsList;
    }
}
