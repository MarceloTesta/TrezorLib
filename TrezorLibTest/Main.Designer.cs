﻿namespace TrezorLibTest
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.initializeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getPubKeyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initializeMenuItem,
            this.getPubKeyMenuItem,
            this.getAddressToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(318, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // initializeMenuItem
            // 
            this.initializeMenuItem.Enabled = false;
            this.initializeMenuItem.Name = "initializeMenuItem";
            this.initializeMenuItem.Size = new System.Drawing.Size(62, 20);
            this.initializeMenuItem.Text = "Initialize";
            this.initializeMenuItem.Click += new System.EventHandler(this.initializeMenuItem_Click);
            // 
            // getPubKeyMenuItem
            // 
            this.getPubKeyMenuItem.Enabled = false;
            this.getPubKeyMenuItem.Name = "getPubKeyMenuItem";
            this.getPubKeyMenuItem.Size = new System.Drawing.Size(66, 20);
            this.getPubKeyMenuItem.Text = "Get xpub";
            this.getPubKeyMenuItem.Click += new System.EventHandler(this.getPubKeyMenuItem_Click);
            // 
            // getAddressToolStripMenuItem
            // 
            this.getAddressToolStripMenuItem.Name = "getAddressToolStripMenuItem";
            this.getAddressToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.getAddressToolStripMenuItem.Text = "Get Address";
            this.getAddressToolStripMenuItem.Click += new System.EventHandler(this.getAddressToolStripMenuItem_Click);
            // 
            // logListBox
            // 
            this.logListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logListBox.FormattingEnabled = true;
            this.logListBox.Location = new System.Drawing.Point(0, 24);
            this.logListBox.Name = "logListBox";
            this.logListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.logListBox.Size = new System.Drawing.Size(318, 372);
            this.logListBox.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 374);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(318, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BackColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 396);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.logListBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem initializeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getPubKeyMenuItem;
        private System.Windows.Forms.ListBox logListBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem getAddressToolStripMenuItem;
    }
}

