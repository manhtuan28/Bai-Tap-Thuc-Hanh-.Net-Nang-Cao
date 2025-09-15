namespace TH3_BT2
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
            this.PanelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPhanSo1 = new System.Windows.Forms.Label();
            this.lblPhanSo2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtKetQua = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhanSo2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhanSo1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnChia = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhan = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamLai = new Guna.UI2.WinForms.Guna2Button();
            this.btnTru = new Guna.UI2.WinForms.Guna2Button();
            this.btnCong = new Guna.UI2.WinForms.Guna2Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelTop.SuspendLayout();
            this.lblPhanSo2.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.lblTitle);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(453, 57);
            this.PanelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(429, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PHÉP TOÁN TRÊN PHÂN SỐ";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPhanSo1
            // 
            this.lblPhanSo1.AutoSize = true;
            this.lblPhanSo1.Location = new System.Drawing.Point(66, 33);
            this.lblPhanSo1.Name = "lblPhanSo1";
            this.lblPhanSo1.Size = new System.Drawing.Size(79, 19);
            this.lblPhanSo1.TabIndex = 1;
            this.lblPhanSo1.Text = "Phân số 1";
            // 
            // lblPhanSo2
            // 
            this.lblPhanSo2.Controls.Add(this.txtKetQua);
            this.lblPhanSo2.Controls.Add(this.txtPhanSo2);
            this.lblPhanSo2.Controls.Add(this.txtPhanSo1);
            this.lblPhanSo2.Controls.Add(this.guna2Panel2);
            this.lblPhanSo2.Controls.Add(this.lblKetQua);
            this.lblPhanSo2.Controls.Add(this.label1);
            this.lblPhanSo2.Controls.Add(this.lblPhanSo1);
            this.lblPhanSo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhanSo2.Location = new System.Drawing.Point(0, 57);
            this.lblPhanSo2.Name = "lblPhanSo2";
            this.lblPhanSo2.Size = new System.Drawing.Size(453, 266);
            this.lblPhanSo2.TabIndex = 2;
            // 
            // txtKetQua
            // 
            this.txtKetQua.BorderRadius = 5;
            this.txtKetQua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKetQua.DefaultText = "";
            this.txtKetQua.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKetQua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKetQua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKetQua.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKetQua.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKetQua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKetQua.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKetQua.Location = new System.Drawing.Point(182, 121);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.PasswordChar = '\0';
            this.txtKetQua.PlaceholderText = "Kết quả";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.SelectedText = "";
            this.txtKetQua.Size = new System.Drawing.Size(211, 27);
            this.txtKetQua.TabIndex = 3;
            // 
            // txtPhanSo2
            // 
            this.txtPhanSo2.Animated = true;
            this.txtPhanSo2.BorderRadius = 5;
            this.txtPhanSo2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhanSo2.DefaultText = "";
            this.txtPhanSo2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhanSo2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhanSo2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhanSo2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhanSo2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhanSo2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhanSo2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhanSo2.Location = new System.Drawing.Point(182, 74);
            this.txtPhanSo2.Name = "txtPhanSo2";
            this.txtPhanSo2.PasswordChar = '\0';
            this.txtPhanSo2.PlaceholderText = "Phân số 2";
            this.txtPhanSo2.SelectedText = "";
            this.txtPhanSo2.Size = new System.Drawing.Size(211, 27);
            this.txtPhanSo2.TabIndex = 3;
            // 
            // txtPhanSo1
            // 
            this.txtPhanSo1.Animated = true;
            this.txtPhanSo1.BorderRadius = 5;
            this.txtPhanSo1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhanSo1.DefaultText = "";
            this.txtPhanSo1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhanSo1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhanSo1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhanSo1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhanSo1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhanSo1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhanSo1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhanSo1.Location = new System.Drawing.Point(182, 29);
            this.txtPhanSo1.Name = "txtPhanSo1";
            this.txtPhanSo1.PasswordChar = '\0';
            this.txtPhanSo1.PlaceholderText = "Phân số 1";
            this.txtPhanSo1.SelectedText = "";
            this.txtPhanSo1.Size = new System.Drawing.Size(211, 27);
            this.txtPhanSo1.TabIndex = 3;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnChia);
            this.guna2Panel2.Controls.Add(this.btnNhan);
            this.guna2Panel2.Controls.Add(this.btnLamLai);
            this.guna2Panel2.Controls.Add(this.btnTru);
            this.guna2Panel2.Controls.Add(this.btnCong);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 178);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(453, 88);
            this.guna2Panel2.TabIndex = 2;
            // 
            // btnChia
            // 
            this.btnChia.Animated = true;
            this.btnChia.BorderRadius = 10;
            this.btnChia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChia.FillColor = System.Drawing.Color.LimeGreen;
            this.btnChia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnChia.ForeColor = System.Drawing.Color.White;
            this.btnChia.Location = new System.Drawing.Point(335, 3);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(95, 35);
            this.btnChia.TabIndex = 0;
            this.btnChia.Text = "Chia";
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Animated = true;
            this.btnNhan.BorderRadius = 10;
            this.btnNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhan.FillColor = System.Drawing.Color.Yellow;
            this.btnNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNhan.ForeColor = System.Drawing.Color.Black;
            this.btnNhan.Location = new System.Drawing.Point(234, 3);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(95, 35);
            this.btnNhan.TabIndex = 0;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Animated = true;
            this.btnLamLai.BorderRadius = 10;
            this.btnLamLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamLai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamLai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamLai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamLai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamLai.FillColor = System.Drawing.Color.Red;
            this.btnLamLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLamLai.ForeColor = System.Drawing.Color.White;
            this.btnLamLai.Location = new System.Drawing.Point(182, 44);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(95, 35);
            this.btnLamLai.TabIndex = 0;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnTru
            // 
            this.btnTru.Animated = true;
            this.btnTru.BorderRadius = 10;
            this.btnTru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTru.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTru.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTru.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTru.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTru.FillColor = System.Drawing.Color.OrangeRed;
            this.btnTru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTru.ForeColor = System.Drawing.Color.White;
            this.btnTru.Location = new System.Drawing.Point(133, 3);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(95, 35);
            this.btnTru.TabIndex = 0;
            this.btnTru.Text = "Trừ";
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnCong
            // 
            this.btnCong.Animated = true;
            this.btnCong.BorderRadius = 10;
            this.btnCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCong.ForeColor = System.Drawing.Color.White;
            this.btnCong.Location = new System.Drawing.Point(32, 3);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(95, 35);
            this.btnCong.TabIndex = 0;
            this.btnCong.Text = "Cộng";
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(66, 125);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(62, 19);
            this.lblKetQua.TabIndex = 1;
            this.lblKetQua.Text = "Kết quả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phân số 2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(453, 323);
            this.Controls.Add(this.lblPhanSo2);
            this.Controls.Add(this.PanelTop);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân Số";
            this.PanelTop.ResumeLayout(false);
            this.lblPhanSo2.ResumeLayout(false);
            this.lblPhanSo2.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelTop;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private System.Windows.Forms.Label lblPhanSo1;
        private Guna.UI2.WinForms.Guna2Panel lblPhanSo2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtKetQua;
        private Guna.UI2.WinForms.Guna2TextBox txtPhanSo2;
        private Guna.UI2.WinForms.Guna2TextBox txtPhanSo1;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnCong;
        private Guna.UI2.WinForms.Guna2Button btnChia;
        private Guna.UI2.WinForms.Guna2Button btnNhan;
        private Guna.UI2.WinForms.Guna2Button btnTru;
        private Guna.UI2.WinForms.Guna2Button btnLamLai;
    }
}

