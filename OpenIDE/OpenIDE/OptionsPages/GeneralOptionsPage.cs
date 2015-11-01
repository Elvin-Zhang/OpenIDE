namespace OpenIDE.OptionsPages
{
    public class GeneralOptionsPage : GLib.Options.OptionsPanel
    {
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadScrollablePanel containerPanel;

        private void InitializeComponent()
        {
            this.containerPanel = new Telerik.WinControls.UI.RadScrollablePanel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.containerPanel)).BeginInit();
            this.containerPanel.PanelContainer.SuspendLayout();
            this.containerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Name = "containerPanel";
            // 
            // containerPanel.PanelContainer
            // 
            this.containerPanel.PanelContainer.Controls.Add(this.radButton1);
            this.containerPanel.PanelContainer.Size = new System.Drawing.Size(776, 493);
            this.containerPanel.Size = new System.Drawing.Size(778, 495);
            this.containerPanel.TabIndex = 0;
            this.containerPanel.ThemeName = "VisualStudio2012Dark";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(298, 66);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 24);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "radButton1";
            this.radButton1.ThemeName = "VisualStudio2012Dark";
            // 
            // GeneralOptionsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CategoryPath = "Options\\\\\"General\"";
            this.Controls.Add(this.containerPanel);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "GeneralOptionsPage";
            this.Size = new System.Drawing.Size(778, 495);
            this.containerPanel.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.containerPanel)).EndInit();
            this.containerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);

        }

        public GeneralOptionsPage()
        {
            InitializeComponent();

            
        }
    }
}