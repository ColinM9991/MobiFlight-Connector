namespace MobiFlight.UI.Panels.Action
{
    partial class HttpRequestInputPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.httpInputActionFormGroup = new System.Windows.Forms.GroupBox();
            this.UrlText = new System.Windows.Forms.TextBox();
            this.UrlLabel = new System.Windows.Forms.Label();
            this.httpInputActionFormGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // httpInputActionFormGroup
            // 
            this.httpInputActionFormGroup.Controls.Add(this.UrlText);
            this.httpInputActionFormGroup.Controls.Add(this.UrlLabel);
            this.httpInputActionFormGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.httpInputActionFormGroup.Location = new System.Drawing.Point(0, 0);
            this.httpInputActionFormGroup.Name = "httpInputActionFormGroup";
            this.httpInputActionFormGroup.Size = new System.Drawing.Size(622, 150);
            this.httpInputActionFormGroup.TabIndex = 25;
            this.httpInputActionFormGroup.TabStop = false;
            this.httpInputActionFormGroup.Text = "HTTP Request settings";
            // 
            // UrlText
            // 
            this.UrlText.Location = new System.Drawing.Point(82, 25);
            this.UrlText.Name = "UrlText";
            this.UrlText.Size = new System.Drawing.Size(534, 20);
            this.UrlText.TabIndex = 16;
            this.UrlText.Validating += new System.ComponentModel.CancelEventHandler(this.UrlText_Validating);
            // 
            // UrlLabel
            // 
            this.UrlLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UrlLabel.Location = new System.Drawing.Point(27, 25);
            this.UrlLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(49, 13);
            this.UrlLabel.TabIndex = 15;
            this.UrlLabel.Text = "URL";
            this.UrlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HttpRequestInputPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.httpInputActionFormGroup);
            this.Name = "HttpRequestInputPanel";
            this.Size = new System.Drawing.Size(622, 150);
            this.httpInputActionFormGroup.ResumeLayout(false);
            this.httpInputActionFormGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox httpInputActionFormGroup;
        private System.Windows.Forms.Label UrlLabel;
        private System.Windows.Forms.TextBox UrlText;
    }
}
