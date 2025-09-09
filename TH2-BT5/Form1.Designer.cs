namespace TH2_BT5
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
            this.lviCongNgheNET = new System.Windows.Forms.ListView();
            this.clMaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clQueQuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCNNet = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mkNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lviCongNgheNET
            // 
            this.lviCongNgheNET.CheckBoxes = true;
            this.lviCongNgheNET.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clMaSV,
            this.clTenSV,
            this.clLop,
            this.clNgaySinh,
            this.clGioiTinh,
            this.clQueQuan});
            this.lviCongNgheNET.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lviCongNgheNET.HideSelection = false;
            this.lviCongNgheNET.Location = new System.Drawing.Point(12, 57);
            this.lviCongNgheNET.Name = "lviCongNgheNET";
            this.lviCongNgheNET.Size = new System.Drawing.Size(898, 270);
            this.lviCongNgheNET.TabIndex = 0;
            this.lviCongNgheNET.UseCompatibleStateImageBehavior = false;
            this.lviCongNgheNET.View = System.Windows.Forms.View.Details;
            this.lviCongNgheNET.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lviCongNgheNET_ItemCheck);
            this.lviCongNgheNET.SelectedIndexChanged += new System.EventHandler(this.lviCongNgheNET_SelectedIndexChanged);
            // 
            // clMaSV
            // 
            this.clMaSV.Text = "Mã SV";
            this.clMaSV.Width = 81;
            // 
            // clTenSV
            // 
            this.clTenSV.Text = "Tên SV";
            this.clTenSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clTenSV.Width = 229;
            // 
            // clLop
            // 
            this.clLop.Text = "Lớp";
            this.clLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clLop.Width = 75;
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.Text = "Ngày Sinh";
            this.clNgaySinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clNgaySinh.Width = 129;
            // 
            // clGioiTinh
            // 
            this.clGioiTinh.Text = "Giới Tính";
            this.clGioiTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clGioiTinh.Width = 78;
            // 
            // clQueQuan
            // 
            this.clQueQuan.Text = "Quê Quán";
            this.clQueQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clQueQuan.Width = 126;
            // 
            // lblCNNet
            // 
            this.lblCNNet.AutoSize = true;
            this.lblCNNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNNet.Location = new System.Drawing.Point(345, 25);
            this.lblCNNet.Name = "lblCNNet";
            this.lblCNNet.Size = new System.Drawing.Size(236, 29);
            this.lblCNNet.TabIndex = 1;
            this.lblCNNet.Text = "CÔNG NGHỆ .NET";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mkNgaySinh);
            this.panel1.Controls.Add(this.lblQueQuan);
            this.panel1.Controls.Add(this.lblGioiTinh);
            this.panel1.Controls.Add(this.lblNgaySinh);
            this.panel1.Controls.Add(this.lblLop);
            this.panel1.Controls.Add(this.lblTenSV);
            this.panel1.Controls.Add(this.lblMaSV);
            this.panel1.Controls.Add(this.txtQueQuan);
            this.panel1.Controls.Add(this.txtGioiTinh);
            this.panel1.Controls.Add(this.txtLop);
            this.panel1.Controls.Add(this.txtTenSV);
            this.panel1.Controls.Add(this.txtMaSV);
            this.panel1.Location = new System.Drawing.Point(12, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 115);
            this.panel1.TabIndex = 2;
            // 
            // mkNgaySinh
            // 
            this.mkNgaySinh.Location = new System.Drawing.Point(497, 57);
            this.mkNgaySinh.Mask = "00/00/0000";
            this.mkNgaySinh.Name = "mkNgaySinh";
            this.mkNgaySinh.Size = new System.Drawing.Size(100, 20);
            this.mkNgaySinh.TabIndex = 12;
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueQuan.Location = new System.Drawing.Point(726, 20);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(79, 16);
            this.lblQueQuan.TabIndex = 11;
            this.lblQueQuan.Text = "Quê Quán:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(628, 20);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(63, 16);
            this.lblGioiTinh.TabIndex = 10;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(494, 20);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(80, 16);
            this.lblNgaySinh.TabIndex = 9;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLop.Location = new System.Drawing.Point(369, 20);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(37, 16);
            this.lblLop.TabIndex = 8;
            this.lblLop.Text = "Lớp:";
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSV.Location = new System.Drawing.Point(175, 20);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(62, 16);
            this.lblTenSV.TabIndex = 7;
            this.lblTenSV.Text = "Tên SV:";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSV.Location = new System.Drawing.Point(34, 20);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(56, 16);
            this.lblMaSV.TabIndex = 6;
            this.lblMaSV.Text = "Mã SV:";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(729, 57);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(141, 20);
            this.txtQueQuan.TabIndex = 5;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(631, 57);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(72, 20);
            this.txtGioiTinh.TabIndex = 4;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(372, 57);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(84, 20);
            this.txtLop.TabIndex = 2;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(178, 57);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(153, 20);
            this.txtTenSV.TabIndex = 1;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(37, 57);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(100, 20);
            this.txtMaSV.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(384, 466);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 38);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Tuancute";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 516);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCNNet);
            this.Controls.Add(this.lviCongNgheNET);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Công Nghệ .NET";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lviCongNgheNET;
        private System.Windows.Forms.Label lblCNNet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.MaskedTextBox mkNgaySinh;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader clMaSV;
        private System.Windows.Forms.ColumnHeader clTenSV;
        private System.Windows.Forms.ColumnHeader clLop;
        private System.Windows.Forms.ColumnHeader clNgaySinh;
        private System.Windows.Forms.ColumnHeader clGioiTinh;
        private System.Windows.Forms.ColumnHeader clQueQuan;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

