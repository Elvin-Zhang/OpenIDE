namespace OpenIDE.Core.Dialogs
{
    partial class NewProjectDialog
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
            this.okButton = new Telerik.WinControls.UI.RadButton();
            this.cancelButton = new Telerik.WinControls.UI.RadButton();
            this.nameLabel = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.projectsList = new Telerik.WinControls.UI.RadListView();
            this.projectsTreeView = new Telerik.WinControls.UI.RadTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.okButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsTreeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(589, 350);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(94, 24);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.ThemeName = "VisualStudio2012Dark";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(489, 350);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 24);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.ThemeName = "VisualStudio2012Dark";
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(13, 310);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(36, 18);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(55, 309);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(628, 21);
            this.radTextBox1.TabIndex = 4;
            this.radTextBox1.ThemeName = "VisualStudio2012Dark";
            this.radTextBox1.TextChanged += new System.EventHandler(this.radTextBox1_TextChanged);
            // 
            // projectsList
            // 
            this.projectsList.AllowColumnReorder = false;
            this.projectsList.AllowColumnResize = false;
            this.projectsList.AllowEdit = false;
            this.projectsList.AllowRemove = false;
            this.projectsList.ItemSize = new System.Drawing.Size(200, 75);
            this.projectsList.Location = new System.Drawing.Point(174, 13);
            this.projectsList.Name = "projectsList";
            this.projectsList.Size = new System.Drawing.Size(509, 279);
            this.projectsList.TabIndex = 0;
            this.projectsList.Text = "radListView1";
            this.projectsList.ThemeName = "VisualStudio2012Dark";
            this.projectsList.SelectedItemChanged += new System.EventHandler(this.radListView1_SelectedItemChanged);
            // 
            // projectsTreeView
            // 
            this.projectsTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.projectsTreeView.Cursor = System.Windows.Forms.Cursors.Default;
            this.projectsTreeView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.projectsTreeView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.projectsTreeView.Location = new System.Drawing.Point(13, 13);
            this.projectsTreeView.Name = "projectsTreeView";
            this.projectsTreeView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.projectsTreeView.Size = new System.Drawing.Size(150, 279);
            this.projectsTreeView.TabIndex = 5;
            this.projectsTreeView.Text = "radTreeView1";
            this.projectsTreeView.ThemeName = "VisualStudio2012Dark";
            // 
            // NewProjectDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 386);
            this.Controls.Add(this.projectsTreeView);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.projectsList);
            this.Name = "NewProjectDialog";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Project";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.okButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsTreeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadButton okButton;
        private Telerik.WinControls.UI.RadButton cancelButton;
        private Telerik.WinControls.UI.RadLabel nameLabel;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadListView projectsList;
        private Telerik.WinControls.UI.RadTreeView projectsTreeView;
    }
}