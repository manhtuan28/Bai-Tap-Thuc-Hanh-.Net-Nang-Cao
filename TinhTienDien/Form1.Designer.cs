namespace TinhTienDien
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
            this.lblChiSoDau = new System.Windows.Forms.Label();
            this.lblChiSoCuoi = new System.Windows.Forms.Label();
            this.txtChiSoDau = new System.Windows.Forms.TextBox();
            this.txtChiSoCuoi = new System.Windows.Forms.TextBox();
            this.lblSoTienPhaiDong = new System.Windows.Forms.Label();
            this.txtSoTienPhaiDong = new System.Windows.Forms.TextBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(410, 66);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "TÍNH TIỀN ĐIỆN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChiSoDau
            // 
            this.lblChiSoDau.AutoSize = true;
            this.lblChiSoDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiSoDau.Location = new System.Drawing.Point(38, 82);
            this.lblChiSoDau.Name = "lblChiSoDau";
            this.lblChiSoDau.Size = new System.Drawing.Size(79, 18);
            this.lblChiSoDau.TabIndex = 1;
            this.lblChiSoDau.Text = "Chỉ số đầu";
            // 
            // lblChiSoCuoi
            // 
            this.lblChiSoCuoi.AutoSize = true;
            this.lblChiSoCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiSoCuoi.Location = new System.Drawing.Point(38, 124);
            this.lblChiSoCuoi.Name = "lblChiSoCuoi";
            this.lblChiSoCuoi.Size = new System.Drawing.Size(83, 18);
            this.lblChiSoCuoi.TabIndex = 1;
            this.lblChiSoCuoi.Text = "Chỉ số cuối";
            // 
            // txtChiSoDau
            // 
            this.txtChiSoDau.Location = new System.Drawing.Point(127, 80);
            this.txtChiSoDau.Name = "txtChiSoDau";
            this.txtChiSoDau.Size = new System.Drawing.Size(228, 20);
            this.txtChiSoDau.TabIndex = 0;
            this.txtChiSoDau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChiSoDau_KeyPress);
            // 
            // txtChiSoCuoi
            // 
            this.txtChiSoCuoi.Location = new System.Drawing.Point(127, 122);
            this.txtChiSoCuoi.Name = "txtChiSoCuoi";
            this.txtChiSoCuoi.Size = new System.Drawing.Size(228, 20);
            this.txtChiSoCuoi.TabIndex = 1;
            this.txtChiSoCuoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChiSoCuoi_KeyPress);
            // 
            // lblSoTienPhaiDong
            // 
            this.lblSoTienPhaiDong.AutoSize = true;
            this.lblSoTienPhaiDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTienPhaiDong.Location = new System.Drawing.Point(38, 167);
            this.lblSoTienPhaiDong.Name = "lblSoTienPhaiDong";
            this.lblSoTienPhaiDong.Size = new System.Drawing.Size(126, 18);
            this.lblSoTienPhaiDong.TabIndex = 1;
            this.lblSoTienPhaiDong.Text = "Số tiền phải đóng:";
            // 
            // txtSoTienPhaiDong
            // 
            this.txtSoTienPhaiDong.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSoTienPhaiDong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoTienPhaiDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSoTienPhaiDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienPhaiDong.ForeColor = System.Drawing.Color.Blue;
            this.txtSoTienPhaiDong.Location = new System.Drawing.Point(170, 169);
            this.txtSoTienPhaiDong.Name = "txtSoTienPhaiDong";
            this.txtSoTienPhaiDong.ReadOnly = true;
            this.txtSoTienPhaiDong.Size = new System.Drawing.Size(228, 19);
            this.txtSoTienPhaiDong.TabIndex = 4;
            // 
            // btnDongY
            // 
            this.btnDongY.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.Location = new System.Drawing.Point(58, 202);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(119, 28);
            this.btnDongY.TabIndex = 2;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLamLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamLai.Location = new System.Drawing.Point(223, 202);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(119, 28);
            this.btnLamLai.TabIndex = 3;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnDongY;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(410, 263);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtSoTienPhaiDong);
            this.Controls.Add(this.txtChiSoCuoi);
            this.Controls.Add(this.txtChiSoDau);
            this.Controls.Add(this.lblSoTienPhaiDong);
            this.Controls.Add(this.lblChiSoCuoi);
            this.Controls.Add(this.lblChiSoDau);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính tiền điện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblChiSoDau;
        private System.Windows.Forms.Label lblChiSoCuoi;
        private System.Windows.Forms.TextBox txtChiSoDau;
        private System.Windows.Forms.TextBox txtChiSoCuoi;
        private System.Windows.Forms.Label lblSoTienPhaiDong;
        private System.Windows.Forms.TextBox txtSoTienPhaiDong;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnLamLai;
    }
}

