namespace DanhMucSinhVien
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
            this.grpThonTinSinhVien = new System.Windows.Forms.GroupBox();
            this.dateTimeNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.grpChuNang = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grpThongTinChungSinhVien = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cloNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpThonTinSinhVien.SuspendLayout();
            this.grpChuNang.SuspendLayout();
            this.grpThongTinChungSinhVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(630, 67);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH MỤC SINH VIÊN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpThonTinSinhVien
            // 
            this.grpThonTinSinhVien.Controls.Add(this.dateTimeNgaySinh);
            this.grpThonTinSinhVien.Controls.Add(this.txtDiaChi);
            this.grpThonTinSinhVien.Controls.Add(this.txtLop);
            this.grpThonTinSinhVien.Controls.Add(this.lblLop);
            this.grpThonTinSinhVien.Controls.Add(this.txtHoTen);
            this.grpThonTinSinhVien.Controls.Add(this.lblDiaChi);
            this.grpThonTinSinhVien.Controls.Add(this.lblNgaySinh);
            this.grpThonTinSinhVien.Controls.Add(this.lblHoTen);
            this.grpThonTinSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThonTinSinhVien.Location = new System.Drawing.Point(6, 100);
            this.grpThonTinSinhVien.Name = "grpThonTinSinhVien";
            this.grpThonTinSinhVien.Size = new System.Drawing.Size(616, 138);
            this.grpThonTinSinhVien.TabIndex = 1;
            this.grpThonTinSinhVien.TabStop = false;
            this.grpThonTinSinhVien.Text = "Thông tin sinh viên";
            // 
            // dateTimeNgaySinh
            // 
            this.dateTimeNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgaySinh.Location = new System.Drawing.Point(114, 86);
            this.dateTimeNgaySinh.Name = "dateTimeNgaySinh";
            this.dateTimeNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dateTimeNgaySinh.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(404, 88);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(205, 22);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(404, 35);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(205, 22);
            this.txtLop.TabIndex = 1;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(340, 37);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(33, 16);
            this.lblLop.TabIndex = 0;
            this.lblLop.Text = "Lớp:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(114, 31);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(205, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(340, 88);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(50, 16);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(30, 88);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(70, 16);
            this.lblNgaySinh.TabIndex = 0;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(30, 35);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(49, 16);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // grpChuNang
            // 
            this.grpChuNang.Controls.Add(this.btnThoat);
            this.grpChuNang.Controls.Add(this.btnXoa);
            this.grpChuNang.Controls.Add(this.btnSua);
            this.grpChuNang.Controls.Add(this.btnThem);
            this.grpChuNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.grpChuNang.Location = new System.Drawing.Point(6, 253);
            this.grpChuNang.Name = "grpChuNang";
            this.grpChuNang.Size = new System.Drawing.Size(616, 78);
            this.grpChuNang.TabIndex = 2;
            this.grpChuNang.TabStop = false;
            this.grpChuNang.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Location = new System.Drawing.Point(491, 24);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 42);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Location = new System.Drawing.Point(335, 24);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 42);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Location = new System.Drawing.Point(179, 24);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 42);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Location = new System.Drawing.Point(30, 24);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 42);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grpThongTinChungSinhVien
            // 
            this.grpThongTinChungSinhVien.Controls.Add(this.listView1);
            this.grpThongTinChungSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.grpThongTinChungSinhVien.Location = new System.Drawing.Point(6, 338);
            this.grpThongTinChungSinhVien.Name = "grpThongTinChungSinhVien";
            this.grpThongTinChungSinhVien.Size = new System.Drawing.Size(616, 171);
            this.grpThongTinChungSinhVien.TabIndex = 3;
            this.grpThongTinChungSinhVien.TabStop = false;
            this.grpThongTinChungSinhVien.Text = "Thông tin chung sinh viên";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHoTen,
            this.cloNgaySinh,
            this.colLop,
            this.colDiaChi});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 18);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(610, 150);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ tên";
            this.colHoTen.Width = 131;
            // 
            // cloNgaySinh
            // 
            this.cloNgaySinh.Text = "Ngày sinh";
            this.cloNgaySinh.Width = 134;
            // 
            // colLop
            // 
            this.colLop.Text = "Lớp";
            this.colLop.Width = 98;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ";
            this.colDiaChi.Width = 231;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 521);
            this.Controls.Add(this.grpThongTinChungSinhVien);
            this.Controls.Add(this.grpChuNang);
            this.Controls.Add(this.grpThonTinSinhVien);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên";
            this.grpThonTinSinhVien.ResumeLayout(false);
            this.grpThonTinSinhVien.PerformLayout();
            this.grpChuNang.ResumeLayout(false);
            this.grpThongTinChungSinhVien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpThonTinSinhVien;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.GroupBox grpChuNang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dateTimeNgaySinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox grpThongTinChungSinhVien;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader cloNgaySinh;
        private System.Windows.Forms.ColumnHeader colLop;
        private System.Windows.Forms.ColumnHeader colDiaChi;
    }
}

