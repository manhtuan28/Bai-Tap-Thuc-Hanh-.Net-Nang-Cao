namespace TH3_BT3
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
            this.grbThongTinHoaDon = new System.Windows.Forms.GroupBox();
            this.dtpNgayLapHoaDon = new System.Windows.Forms.DateTimePicker();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.txtSoHoaDon = new System.Windows.Forms.TextBox();
            this.lblNgayLapHoaDon = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.lblSoHoaDon = new System.Windows.Forms.Label();
            this.grbChiTietHoaDon = new System.Windows.Forms.GroupBox();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtSanPham = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lvChiTiet = new System.Windows.Forms.ListView();
            this.btnThemChiTiet = new System.Windows.Forms.Button();
            this.btnThemHoaDon = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.colSanPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbThongTinHoaDon.SuspendLayout();
            this.grbChiTietHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(928, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "NHẬP THÔNG TIN HÓA ĐƠN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbThongTinHoaDon
            // 
            this.grbThongTinHoaDon.Controls.Add(this.dtpNgayLapHoaDon);
            this.grbThongTinHoaDon.Controls.Add(this.txtKhachHang);
            this.grbThongTinHoaDon.Controls.Add(this.txtSoHoaDon);
            this.grbThongTinHoaDon.Controls.Add(this.lblNgayLapHoaDon);
            this.grbThongTinHoaDon.Controls.Add(this.lblKhachHang);
            this.grbThongTinHoaDon.Controls.Add(this.lblSoHoaDon);
            this.grbThongTinHoaDon.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinHoaDon.Location = new System.Drawing.Point(12, 51);
            this.grbThongTinHoaDon.Name = "grbThongTinHoaDon";
            this.grbThongTinHoaDon.Size = new System.Drawing.Size(902, 130);
            this.grbThongTinHoaDon.TabIndex = 1;
            this.grbThongTinHoaDon.TabStop = false;
            this.grbThongTinHoaDon.Text = "Thông tin hóa đơn";
            // 
            // dtpNgayLapHoaDon
            // 
            this.dtpNgayLapHoaDon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLapHoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLapHoaDon.Location = new System.Drawing.Point(172, 86);
            this.dtpNgayLapHoaDon.Name = "dtpNgayLapHoaDon";
            this.dtpNgayLapHoaDon.Size = new System.Drawing.Size(184, 27);
            this.dtpNgayLapHoaDon.TabIndex = 1;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhachHang.Location = new System.Drawing.Point(539, 47);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(313, 27);
            this.txtKhachHang.TabIndex = 2;
            // 
            // txtSoHoaDon
            // 
            this.txtSoHoaDon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoHoaDon.Location = new System.Drawing.Point(171, 41);
            this.txtSoHoaDon.Name = "txtSoHoaDon";
            this.txtSoHoaDon.Size = new System.Drawing.Size(185, 27);
            this.txtSoHoaDon.TabIndex = 5;
            // 
            // lblNgayLapHoaDon
            // 
            this.lblNgayLapHoaDon.AutoSize = true;
            this.lblNgayLapHoaDon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLapHoaDon.Location = new System.Drawing.Point(31, 90);
            this.lblNgayLapHoaDon.Name = "lblNgayLapHoaDon";
            this.lblNgayLapHoaDon.Size = new System.Drawing.Size(134, 19);
            this.lblNgayLapHoaDon.TabIndex = 0;
            this.lblNgayLapHoaDon.Text = "Ngày lập hóa đơn";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.Location = new System.Drawing.Point(442, 51);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(91, 19);
            this.lblKhachHang.TabIndex = 0;
            this.lblKhachHang.Text = "Khách hàng";
            // 
            // lblSoHoaDon
            // 
            this.lblSoHoaDon.AutoSize = true;
            this.lblSoHoaDon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoHoaDon.Location = new System.Drawing.Point(31, 45);
            this.lblSoHoaDon.Name = "lblSoHoaDon";
            this.lblSoHoaDon.Size = new System.Drawing.Size(90, 19);
            this.lblSoHoaDon.TabIndex = 0;
            this.lblSoHoaDon.Text = "Số hóa đơn";
            // 
            // grbChiTietHoaDon
            // 
            this.grbChiTietHoaDon.Controls.Add(this.btnThemChiTiet);
            this.grbChiTietHoaDon.Controls.Add(this.txtSoLuong);
            this.grbChiTietHoaDon.Controls.Add(this.txtDonGia);
            this.grbChiTietHoaDon.Controls.Add(this.txtSanPham);
            this.grbChiTietHoaDon.Controls.Add(this.lblDonGia);
            this.grbChiTietHoaDon.Controls.Add(this.lblSoLuong);
            this.grbChiTietHoaDon.Controls.Add(this.lblSanPham);
            this.grbChiTietHoaDon.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.grbChiTietHoaDon.ForeColor = System.Drawing.Color.Blue;
            this.grbChiTietHoaDon.Location = new System.Drawing.Point(12, 188);
            this.grbChiTietHoaDon.Name = "grbChiTietHoaDon";
            this.grbChiTietHoaDon.Size = new System.Drawing.Size(376, 215);
            this.grbChiTietHoaDon.TabIndex = 2;
            this.grbChiTietHoaDon.TabStop = false;
            this.grbChiTietHoaDon.Text = "Chi tiết hóa đơn";
            // 
            // lblSanPham
            // 
            this.lblSanPham.AutoSize = true;
            this.lblSanPham.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanPham.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSanPham.Location = new System.Drawing.Point(31, 50);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(80, 19);
            this.lblSanPham.TabIndex = 0;
            this.lblSanPham.Text = "Sản phẩm";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSoLuong.Location = new System.Drawing.Point(31, 135);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(73, 19);
            this.lblSoLuong.TabIndex = 0;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDonGia.Location = new System.Drawing.Point(31, 92);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(64, 19);
            this.lblDonGia.TabIndex = 0;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // txtSanPham
            // 
            this.txtSanPham.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSanPham.Location = new System.Drawing.Point(127, 46);
            this.txtSanPham.Name = "txtSanPham";
            this.txtSanPham.Size = new System.Drawing.Size(229, 27);
            this.txtSanPham.TabIndex = 0;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(127, 88);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(125, 27);
            this.txtDonGia.TabIndex = 1;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(127, 131);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(125, 27);
            this.txtSoLuong.TabIndex = 2;
            // 
            // lvChiTiet
            // 
            this.lvChiTiet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSanPham,
            this.colDonGia,
            this.colSoLuong,
            this.colThanhTien});
            this.lvChiTiet.HideSelection = false;
            this.lvChiTiet.Location = new System.Drawing.Point(395, 204);
            this.lvChiTiet.Name = "lvChiTiet";
            this.lvChiTiet.Size = new System.Drawing.Size(519, 199);
            this.lvChiTiet.TabIndex = 3;
            this.lvChiTiet.UseCompatibleStateImageBehavior = false;
            this.lvChiTiet.View = System.Windows.Forms.View.Details;
            // 
            // btnThemChiTiet
            // 
            this.btnThemChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemChiTiet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemChiTiet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThemChiTiet.Location = new System.Drawing.Point(106, 172);
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.Size = new System.Drawing.Size(181, 33);
            this.btnThemChiTiet.TabIndex = 3;
            this.btnThemChiTiet.Text = "Thêm chi tiết";
            this.btnThemChiTiet.UseVisualStyleBackColor = true;
            this.btnThemChiTiet.Click += new System.EventHandler(this.btnThemChiTiet_Click);
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemHoaDon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHoaDon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThemHoaDon.Location = new System.Drawing.Point(395, 421);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(248, 33);
            this.btnThemHoaDon.TabIndex = 4;
            this.btnThemHoaDon.Text = "Thêm hóa đơn";
            this.btnThemHoaDon.UseVisualStyleBackColor = true;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHoaDon_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamLai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamLai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLamLai.Location = new System.Drawing.Point(666, 421);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(248, 33);
            this.btnLamLai.TabIndex = 1;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // colSanPham
            // 
            this.colSanPham.Text = "Sản phẩm";
            this.colSanPham.Width = 118;
            // 
            // colDonGia
            // 
            this.colDonGia.Text = "Đơn giá";
            this.colDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDonGia.Width = 149;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSoLuong.Width = 94;
            // 
            // colThanhTien
            // 
            this.colThanhTien.Text = "Thành Tiền";
            this.colThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colThanhTien.Width = 153;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 466);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnThemHoaDon);
            this.Controls.Add(this.lvChiTiet);
            this.Controls.Add(this.grbChiTietHoaDon);
            this.Controls.Add(this.grbThongTinHoaDon);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình nhập thông tin hóa đơn";
            this.grbThongTinHoaDon.ResumeLayout(false);
            this.grbThongTinHoaDon.PerformLayout();
            this.grbChiTietHoaDon.ResumeLayout(false);
            this.grbChiTietHoaDon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbThongTinHoaDon;
        private System.Windows.Forms.Label lblSoHoaDon;
        private System.Windows.Forms.Label lblNgayLapHoaDon;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.TextBox txtSoHoaDon;
        private System.Windows.Forms.DateTimePicker dtpNgayLapHoaDon;
        private System.Windows.Forms.GroupBox grbChiTietHoaDon;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtSanPham;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ListView lvChiTiet;
        private System.Windows.Forms.Button btnThemChiTiet;
        private System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.ColumnHeader colSanPham;
        private System.Windows.Forms.ColumnHeader colDonGia;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colThanhTien;
    }
}

