namespace TinhTienHocTrungTam
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
            this.lblTitile = new System.Windows.Forms.Label();
            this.lblMaHocVien = new System.Windows.Forms.Label();
            this.cbbMaHocVien = new System.Windows.Forms.ComboBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rdbtnNam = new System.Windows.Forms.RadioButton();
            this.rdbtnNu = new System.Windows.Forms.RadioButton();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgayDangKy = new System.Windows.Forms.Label();
            this.dateTimeNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTiengAnhB = new System.Windows.Forms.Label();
            this.lblTiengAnhA = new System.Windows.Forms.Label();
            this.lblTinhHocB = new System.Windows.Forms.Label();
            this.lblTinhHocA = new System.Windows.Forms.Label();
            this.ckbTiengAnhB = new System.Windows.Forms.CheckBox();
            this.ckbTiengAnhA = new System.Windows.Forms.CheckBox();
            this.ckbTinHocB = new System.Windows.Forms.CheckBox();
            this.ckbTinHocA = new System.Windows.Forms.CheckBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitile
            // 
            this.lblTitile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitile.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblTitile.Location = new System.Drawing.Point(0, 0);
            this.lblTitile.Name = "lblTitile";
            this.lblTitile.Size = new System.Drawing.Size(897, 77);
            this.lblTitile.TabIndex = 6;
            this.lblTitile.Text = "TÍNH TIỀN HỌC TRUNG TÂM";
            this.lblTitile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaHocVien
            // 
            this.lblMaHocVien.AutoSize = true;
            this.lblMaHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHocVien.Location = new System.Drawing.Point(30, 95);
            this.lblMaHocVien.Name = "lblMaHocVien";
            this.lblMaHocVien.Size = new System.Drawing.Size(104, 18);
            this.lblMaHocVien.TabIndex = 7;
            this.lblMaHocVien.Text = "Mã Học Viên";
            // 
            // cbbMaHocVien
            // 
            this.cbbMaHocVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaHocVien.FormattingEnabled = true;
            this.cbbMaHocVien.Items.AddRange(new object[] {
            "ABC123",
            "ABC456",
            "ABC789",
            "BCD123",
            "BCD456",
            "BCD789"});
            this.cbbMaHocVien.Location = new System.Drawing.Point(149, 95);
            this.cbbMaHocVien.Name = "cbbMaHocVien";
            this.cbbMaHocVien.Size = new System.Drawing.Size(527, 21);
            this.cbbMaHocVien.TabIndex = 9;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(682, 96);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(76, 18);
            this.lblGioiTinh.TabIndex = 1;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // rdbtnNam
            // 
            this.rdbtnNam.AutoSize = true;
            this.rdbtnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnNam.Location = new System.Drawing.Point(764, 96);
            this.rdbtnNam.Name = "rdbtnNam";
            this.rdbtnNam.Size = new System.Drawing.Size(54, 20);
            this.rdbtnNam.TabIndex = 2;
            this.rdbtnNam.TabStop = true;
            this.rdbtnNam.Text = "Nam";
            this.rdbtnNam.UseVisualStyleBackColor = true;
            // 
            // rdbtnNu
            // 
            this.rdbtnNu.AutoSize = true;
            this.rdbtnNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnNu.Location = new System.Drawing.Point(824, 96);
            this.rdbtnNu.Name = "rdbtnNu";
            this.rdbtnNu.Size = new System.Drawing.Size(42, 20);
            this.rdbtnNu.TabIndex = 4;
            this.rdbtnNu.TabStop = true;
            this.rdbtnNu.Text = "Nữ";
            this.rdbtnNu.UseVisualStyleBackColor = true;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(30, 139);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(63, 18);
            this.lblHoTen.TabIndex = 8;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(149, 137);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(723, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblNgayDangKy
            // 
            this.lblNgayDangKy.AutoSize = true;
            this.lblNgayDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDangKy.Location = new System.Drawing.Point(30, 184);
            this.lblNgayDangKy.Name = "lblNgayDangKy";
            this.lblNgayDangKy.Size = new System.Drawing.Size(112, 18);
            this.lblNgayDangKy.TabIndex = 1;
            this.lblNgayDangKy.Text = "Ngày Đăng ký";
            // 
            // dateTimeNgayDangKy
            // 
            this.dateTimeNgayDangKy.Location = new System.Drawing.Point(149, 181);
            this.dateTimeNgayDangKy.Name = "dateTimeNgayDangKy";
            this.dateTimeNgayDangKy.Size = new System.Drawing.Size(723, 20);
            this.dateTimeNgayDangKy.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.lblTiengAnhB);
            this.groupBox1.Controls.Add(this.lblTiengAnhA);
            this.groupBox1.Controls.Add(this.lblTinhHocB);
            this.groupBox1.Controls.Add(this.lblTinhHocA);
            this.groupBox1.Controls.Add(this.ckbTiengAnhB);
            this.groupBox1.Controls.Add(this.ckbTiengAnhA);
            this.groupBox1.Controls.Add(this.ckbTinHocB);
            this.groupBox1.Controls.Add(this.ckbTinHocA);
            this.groupBox1.Controls.Add(this.lblTongTien);
            this.groupBox1.Location = new System.Drawing.Point(33, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 192);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(155, 159);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(276, 22);
            this.txtTongTien.TabIndex = 2;
            // 
            // lblTiengAnhB
            // 
            this.lblTiengAnhB.AutoSize = true;
            this.lblTiengAnhB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiengAnhB.Location = new System.Drawing.Point(334, 126);
            this.lblTiengAnhB.Name = "lblTiengAnhB";
            this.lblTiengAnhB.Size = new System.Drawing.Size(97, 18);
            this.lblTiengAnhB.TabIndex = 1;
            this.lblTiengAnhB.Text = "600.000 đồng";
            // 
            // lblTiengAnhA
            // 
            this.lblTiengAnhA.AutoSize = true;
            this.lblTiengAnhA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiengAnhA.Location = new System.Drawing.Point(334, 92);
            this.lblTiengAnhA.Name = "lblTiengAnhA";
            this.lblTiengAnhA.Size = new System.Drawing.Size(97, 18);
            this.lblTiengAnhA.TabIndex = 1;
            this.lblTiengAnhA.Text = "400.000 đồng";
            // 
            // lblTinhHocB
            // 
            this.lblTinhHocB.AutoSize = true;
            this.lblTinhHocB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhHocB.Location = new System.Drawing.Point(334, 55);
            this.lblTinhHocB.Name = "lblTinhHocB";
            this.lblTinhHocB.Size = new System.Drawing.Size(97, 18);
            this.lblTinhHocB.TabIndex = 1;
            this.lblTinhHocB.Text = "500.000 đồng";
            // 
            // lblTinhHocA
            // 
            this.lblTinhHocA.AutoSize = true;
            this.lblTinhHocA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhHocA.Location = new System.Drawing.Point(334, 21);
            this.lblTinhHocA.Name = "lblTinhHocA";
            this.lblTinhHocA.Size = new System.Drawing.Size(97, 18);
            this.lblTinhHocA.TabIndex = 1;
            this.lblTinhHocA.Text = "300.000 đồng";
            // 
            // ckbTiengAnhB
            // 
            this.ckbTiengAnhB.AutoSize = true;
            this.ckbTiengAnhB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTiengAnhB.Location = new System.Drawing.Point(19, 123);
            this.ckbTiengAnhB.Name = "ckbTiengAnhB";
            this.ckbTiengAnhB.Size = new System.Drawing.Size(99, 20);
            this.ckbTiengAnhB.TabIndex = 3;
            this.ckbTiengAnhB.Text = "Tiếng Anh B";
            this.ckbTiengAnhB.UseVisualStyleBackColor = true;
            // 
            // ckbTiengAnhA
            // 
            this.ckbTiengAnhA.AutoSize = true;
            this.ckbTiengAnhA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTiengAnhA.Location = new System.Drawing.Point(19, 88);
            this.ckbTiengAnhA.Name = "ckbTiengAnhA";
            this.ckbTiengAnhA.Size = new System.Drawing.Size(99, 20);
            this.ckbTiengAnhA.TabIndex = 2;
            this.ckbTiengAnhA.Text = "Tiếng Anh A";
            this.ckbTiengAnhA.UseVisualStyleBackColor = true;
            // 
            // ckbTinHocB
            // 
            this.ckbTinHocB.AutoSize = true;
            this.ckbTinHocB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTinHocB.Location = new System.Drawing.Point(20, 53);
            this.ckbTinHocB.Name = "ckbTinHocB";
            this.ckbTinHocB.Size = new System.Drawing.Size(82, 20);
            this.ckbTinHocB.TabIndex = 1;
            this.ckbTinHocB.Text = "Tín học B";
            this.ckbTinHocB.UseVisualStyleBackColor = true;
            // 
            // ckbTinHocA
            // 
            this.ckbTinHocA.AutoSize = true;
            this.ckbTinHocA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTinHocA.Location = new System.Drawing.Point(20, 19);
            this.ckbTinHocA.Name = "ckbTinHocA";
            this.ckbTinHocA.Size = new System.Drawing.Size(82, 20);
            this.ckbTinHocA.TabIndex = 1;
            this.ckbTinHocA.Text = "Tín học A";
            this.ckbTinHocA.UseVisualStyleBackColor = true;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(35, 160);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(83, 18);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.ForeColor = System.Drawing.Color.Blue;
            this.btnTinhTien.Location = new System.Drawing.Point(71, 440);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(133, 43);
            this.btnTinhTien.TabIndex = 5;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(406, 440);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 43);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "❌ Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Blue;
            this.btnExit.Location = new System.Drawing.Point(700, 440);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 43);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtThongTin);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(511, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 192);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // txtThongTin
            // 
            this.txtThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongTin.Location = new System.Drawing.Point(19, 20);
            this.txtThongTin.Multiline = true;
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.ReadOnly = true;
            this.txtThongTin.Size = new System.Drawing.Size(336, 159);
            this.txtThongTin.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 514);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimeNgayDangKy);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.rdbtnNu);
            this.Controls.Add(this.rdbtnNam);
            this.Controls.Add(this.cbbMaHocVien);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblNgayDangKy);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMaHocVien);
            this.Controls.Add(this.lblTitile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính tiền học trung tâm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitile;
        private System.Windows.Forms.Label lblMaHocVien;
        private System.Windows.Forms.ComboBox cbbMaHocVien;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rdbtnNam;
        private System.Windows.Forms.RadioButton rdbtnNu;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgayDangKy;
        private System.Windows.Forms.DateTimePicker dateTimeNgayDangKy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbTinHocA;
        private System.Windows.Forms.CheckBox ckbTiengAnhB;
        private System.Windows.Forms.CheckBox ckbTiengAnhA;
        private System.Windows.Forms.CheckBox ckbTinHocB;
        private System.Windows.Forms.Label lblTinhHocA;
        private System.Windows.Forms.Label lblTiengAnhB;
        private System.Windows.Forms.Label lblTiengAnhA;
        private System.Windows.Forms.Label lblTinhHocB;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtThongTin;
    }
}

