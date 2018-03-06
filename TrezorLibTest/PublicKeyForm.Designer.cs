namespace TrezorLibTest
{
    partial class PublicKeyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublicKeyForm));
            this.publicKeyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // publicKeyTextBox
            // 
            this.publicKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publicKeyTextBox.Location = new System.Drawing.Point(12, 12);
            this.publicKeyTextBox.Name = "publicKeyTextBox";
            this.publicKeyTextBox.Size = new System.Drawing.Size(847, 20);
            this.publicKeyTextBox.TabIndex = 0;
            // 
            // PublicKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 43);
            this.Controls.Add(this.publicKeyTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PublicKeyForm";
            this.Text = "Public Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox publicKeyTextBox;
    }
}