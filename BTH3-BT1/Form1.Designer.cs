namespace BTH3_BT1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPhuongTrinh = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblXandSum = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblBang = new System.Windows.Forms.Label();
            this.lblResultPT = new System.Windows.Forms.Label();
            this.lblNghiem = new System.Windows.Forms.Label();
            this.txtNghiem = new System.Windows.Forms.TextBox();
            this.btnGiaiPT = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(488, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GIẢI PHƯƠNG TRÌNH BẬC 1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhuongTrinh
            // 
            this.lblPhuongTrinh.AutoSize = true;
            this.lblPhuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhuongTrinh.Location = new System.Drawing.Point(47, 68);
            this.lblPhuongTrinh.Name = "lblPhuongTrinh";
            this.lblPhuongTrinh.Size = new System.Drawing.Size(99, 20);
            this.lblPhuongTrinh.TabIndex = 1;
            this.lblPhuongTrinh.Text = "Phương trình";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(170, 68);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(82, 20);
            this.txtA.TabIndex = 2;
            // 
            // lblXandSum
            // 
            this.lblXandSum.AutoSize = true;
            this.lblXandSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXandSum.Location = new System.Drawing.Point(266, 70);
            this.lblXandSum.Name = "lblXandSum";
            this.lblXandSum.Size = new System.Drawing.Size(20, 16);
            this.lblXandSum.TabIndex = 3;
            this.lblXandSum.Text = "x+";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(300, 68);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(82, 20);
            this.txtB.TabIndex = 4;
            // 
            // lblBang
            // 
            this.lblBang.AutoSize = true;
            this.lblBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBang.Location = new System.Drawing.Point(393, 70);
            this.lblBang.Name = "lblBang";
            this.lblBang.Size = new System.Drawing.Size(18, 20);
            this.lblBang.TabIndex = 5;
            this.lblBang.Text = "=";
            // 
            // lblResultPT
            // 
            this.lblResultPT.AutoSize = true;
            this.lblResultPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultPT.Location = new System.Drawing.Point(421, 69);
            this.lblResultPT.Name = "lblResultPT";
            this.lblResultPT.Size = new System.Drawing.Size(18, 20);
            this.lblResultPT.TabIndex = 5;
            this.lblResultPT.Text = "0";
            // 
            // lblNghiem
            // 
            this.lblNghiem.AutoSize = true;
            this.lblNghiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNghiem.Location = new System.Drawing.Point(47, 111);
            this.lblNghiem.Name = "lblNghiem";
            this.lblNghiem.Size = new System.Drawing.Size(63, 20);
            this.lblNghiem.TabIndex = 1;
            this.lblNghiem.Text = "Nghiệm";
            // 
            // txtNghiem
            // 
            this.txtNghiem.Location = new System.Drawing.Point(170, 111);
            this.txtNghiem.Name = "txtNghiem";
            this.txtNghiem.ReadOnly = true;
            this.txtNghiem.Size = new System.Drawing.Size(269, 20);
            this.txtNghiem.TabIndex = 6;
            // 
            // btnGiaiPT
            // 
            this.btnGiaiPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiPT.Location = new System.Drawing.Point(102, 147);
            this.btnGiaiPT.Name = "btnGiaiPT";
            this.btnGiaiPT.Size = new System.Drawing.Size(109, 32);
            this.btnGiaiPT.TabIndex = 7;
            this.btnGiaiPT.Text = "Giải PT";
            this.btnGiaiPT.UseVisualStyleBackColor = true;
            this.btnGiaiPT.Click += new System.EventHandler(this.btnGiaiPT_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamLai.Location = new System.Drawing.Point(284, 147);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(109, 32);
            this.btnLamLai.TabIndex = 7;
            this.btnLamLai.Text = "Làm Lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 191);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnGiaiPT);
            this.Controls.Add(this.txtNghiem);
            this.Controls.Add(this.lblResultPT);
            this.Controls.Add(this.lblBang);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblXandSum);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblNghiem);
            this.Controls.Add(this.lblPhuongTrinh);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giải phương trình bậc 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPhuongTrinh;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblXandSum;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblBang;
        private System.Windows.Forms.Label lblResultPT;
        private System.Windows.Forms.Label lblNghiem;
        private System.Windows.Forms.TextBox txtNghiem;
        private System.Windows.Forms.Button btnGiaiPT;
        private System.Windows.Forms.Button btnLamLai;
    }
}

