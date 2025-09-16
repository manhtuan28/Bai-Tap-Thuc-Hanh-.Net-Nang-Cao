namespace TH3_BT4
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
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblNamSinh = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnThemSV = new System.Windows.Forms.Button();
            this.btnLuuSV = new System.Windows.Forms.Button();
            this.btnDocSV = new System.Windows.Forms.Button();
            this.grbDanhSachSinhVien = new System.Windows.Forms.GroupBox();
            this.lstSV = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.grbDanhSachSinhVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(31, 39);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(29, 19);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(31, 89);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(36, 19);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên";
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.AutoSize = true;
            this.lblNamSinh.Location = new System.Drawing.Point(31, 133);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(78, 19);
            this.lblNamSinh.TabIndex = 0;
            this.lblNamSinh.Text = "Năm Sinh";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(143, 35);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(374, 27);
            this.txtMa.TabIndex = 0;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(143, 85);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(374, 27);
            this.txtTen.TabIndex = 1;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(143, 129);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(374, 27);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // btnThemSV
            // 
            this.btnThemSV.Location = new System.Drawing.Point(143, 183);
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(95, 39);
            this.btnThemSV.TabIndex = 3;
            this.btnThemSV.Text = "Thêm SV";
            this.btnThemSV.UseVisualStyleBackColor = true;
            this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);
            // 
            // btnLuuSV
            // 
            this.btnLuuSV.Location = new System.Drawing.Point(283, 183);
            this.btnLuuSV.Name = "btnLuuSV";
            this.btnLuuSV.Size = new System.Drawing.Size(95, 39);
            this.btnLuuSV.TabIndex = 4;
            this.btnLuuSV.Text = "Lưu SV";
            this.btnLuuSV.UseVisualStyleBackColor = true;
            this.btnLuuSV.Click += new System.EventHandler(this.btnLuuSV_Click);
            // 
            // btnDocSV
            // 
            this.btnDocSV.Location = new System.Drawing.Point(422, 183);
            this.btnDocSV.Name = "btnDocSV";
            this.btnDocSV.Size = new System.Drawing.Size(95, 39);
            this.btnDocSV.TabIndex = 5;
            this.btnDocSV.Text = "Đọc SV";
            this.btnDocSV.UseVisualStyleBackColor = true;
            this.btnDocSV.Click += new System.EventHandler(this.btnDocSV_Click);
            // 
            // grbDanhSachSinhVien
            // 
            this.grbDanhSachSinhVien.Controls.Add(this.lstSV);
            this.grbDanhSachSinhVien.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachSinhVien.Location = new System.Drawing.Point(35, 266);
            this.grbDanhSachSinhVien.Name = "grbDanhSachSinhVien";
            this.grbDanhSachSinhVien.Size = new System.Drawing.Size(482, 176);
            this.grbDanhSachSinhVien.TabIndex = 4;
            this.grbDanhSachSinhVien.TabStop = false;
            this.grbDanhSachSinhVien.Text = "Danh Sách Sinh Viên";
            // 
            // lstSV
            // 
            this.lstSV.FormattingEnabled = true;
            this.lstSV.ItemHeight = 16;
            this.lstSV.Location = new System.Drawing.Point(7, 23);
            this.lstSV.Name = "lstSV";
            this.lstSV.Size = new System.Drawing.Size(469, 148);
            this.lstSV.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 469);
            this.Controls.Add(this.grbDanhSachSinhVien);
            this.Controls.Add(this.btnDocSV);
            this.Controls.Add(this.btnLuuSV);
            this.Controls.Add(this.btnThemSV);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lblNamSinh);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblMa);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Sinh Viên";
            this.grbDanhSachSinhVien.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblNamSinh;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnThemSV;
        private System.Windows.Forms.Button btnLuuSV;
        private System.Windows.Forms.Button btnDocSV;
        private System.Windows.Forms.GroupBox grbDanhSachSinhVien;
        private System.Windows.Forms.ListBox lstSV;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

