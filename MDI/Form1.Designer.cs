﻿namespace MDI
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bàiTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frm1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frm2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bàiTậpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bàiTậpToolStripMenuItem
            // 
            this.bàiTậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frm1ToolStripMenuItem,
            this.frm2ToolStripMenuItem});
            this.bàiTậpToolStripMenuItem.Name = "bàiTậpToolStripMenuItem";
            this.bàiTậpToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.bàiTậpToolStripMenuItem.Text = "Bài Tập";
            // 
            // frm1ToolStripMenuItem
            // 
            this.frm1ToolStripMenuItem.Name = "frm1ToolStripMenuItem";
            this.frm1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.frm1ToolStripMenuItem.Text = "frm1";
            this.frm1ToolStripMenuItem.Click += new System.EventHandler(this.frm1ToolStripMenuItem_Click);
            // 
            // frm2ToolStripMenuItem
            // 
            this.frm2ToolStripMenuItem.Name = "frm2ToolStripMenuItem";
            this.frm2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.frm2ToolStripMenuItem.Text = "frm2";
            this.frm2ToolStripMenuItem.Click += new System.EventHandler(this.frm2ToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bàiTậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frm1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frm2ToolStripMenuItem;
    }
}

