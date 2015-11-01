namespace OpenIDE.Core.Dialogs
{
    partial class BetaKeyDialog
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
            this.descriptionLabel = new Telerik.WinControls.UI.RadLabel();
            this.keyTextBox = new Telerik.WinControls.UI.RadTextBoxControl();
            this.okButton = new Telerik.WinControls.UI.RadButton();
            this.cancelButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Location = new System.Drawing.Point(13, 13);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(245, 17);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "<html>Please enter your Beta-Key to try <strong>OpenDevelop</strong>:</html>";
            this.descriptionLabel.ThemeName = "VisualStudio2012Dark";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(13, 38);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.NullText = "BetaKey";
            this.keyTextBox.Size = new System.Drawing.Size(519, 20);
            this.keyTextBox.TabIndex = 1;
            this.keyTextBox.ThemeName = "VisualStudio2012Dark";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(422, 65);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(110, 24);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.ThemeName = "VisualStudio2012Dark";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(306, 65);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 24);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.ThemeName = "VisualStudio2012Dark";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // BetaKeyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 96);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BetaKeyDialog";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Beta Key";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.descriptionLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel descriptionLabel;
        private Telerik.WinControls.UI.RadTextBoxControl keyTextBox;
        private Telerik.WinControls.UI.RadButton okButton;
        private Telerik.WinControls.UI.RadButton cancelButton;
    }
}
