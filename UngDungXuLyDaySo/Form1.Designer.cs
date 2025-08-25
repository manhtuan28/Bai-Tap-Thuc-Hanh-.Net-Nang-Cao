namespace UngDungXuLyDaySo
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
            this.grpNhapSoNguyen = new System.Windows.Forms.GroupBox();
            this.btnNhapSo = new System.Windows.Forms.Button();
            this.txtNhapSoNguyen = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lsbDaySo = new System.Windows.Forms.ListBox();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnXoaPhanTuCuoi = new System.Windows.Forms.Button();
            this.btnXoaPhanTuDau = new System.Windows.Forms.Button();
            this.btnXoaPhanTuDangChon = new System.Windows.Forms.Button();
            this.btnChonSoLeCuoi = new System.Windows.Forms.Button();
            this.btnChonSoChanDau = new System.Windows.Forms.Button();
            this.btnTangMoiPhanTuLen2 = new System.Windows.Forms.Button();
            this.btnKetThucUngDung = new System.Windows.Forms.Button();
            this.btnXoaDaySo = new System.Windows.Forms.Button();
            this.grpNhapSoNguyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(486, 69);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ứng dụng xử lý dãy số";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpNhapSoNguyen
            // 
            this.grpNhapSoNguyen.Controls.Add(this.btnNhapSo);
            this.grpNhapSoNguyen.Controls.Add(this.txtNhapSoNguyen);
            this.grpNhapSoNguyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNhapSoNguyen.Location = new System.Drawing.Point(13, 73);
            this.grpNhapSoNguyen.Name = "grpNhapSoNguyen";
            this.grpNhapSoNguyen.Size = new System.Drawing.Size(461, 77);
            this.grpNhapSoNguyen.TabIndex = 1;
            this.grpNhapSoNguyen.TabStop = false;
            this.grpNhapSoNguyen.Text = "Nhập số nguyên";
            // 
            // btnNhapSo
            // 
            this.btnNhapSo.Location = new System.Drawing.Point(297, 31);
            this.btnNhapSo.Name = "btnNhapSo";
            this.btnNhapSo.Size = new System.Drawing.Size(105, 28);
            this.btnNhapSo.TabIndex = 1;
            this.btnNhapSo.Text = "Nhập số";
            this.btnNhapSo.UseVisualStyleBackColor = true;
            this.btnNhapSo.Click += new System.EventHandler(this.btnNhapSo_Click);
            // 
            // txtNhapSoNguyen
            // 
            this.txtNhapSoNguyen.Location = new System.Drawing.Point(64, 34);
            this.txtNhapSoNguyen.Name = "txtNhapSoNguyen";
            this.txtNhapSoNguyen.Size = new System.Drawing.Size(227, 22);
            this.txtNhapSoNguyen.TabIndex = 0;
            this.txtNhapSoNguyen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapSoNguyen_KeyPress);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(13, 156);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lsbDaySo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpChucNang);
            this.splitContainer1.Panel2.Tag = "";
            this.splitContainer1.Size = new System.Drawing.Size(461, 240);
            this.splitContainer1.SplitterDistance = 153;
            this.splitContainer1.TabIndex = 2;
            // 
            // lsbDaySo
            // 
            this.lsbDaySo.FormattingEnabled = true;
            this.lsbDaySo.Location = new System.Drawing.Point(0, 4);
            this.lsbDaySo.Name = "lsbDaySo";
            this.lsbDaySo.Size = new System.Drawing.Size(147, 225);
            this.lsbDaySo.TabIndex = 0;
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnXoaPhanTuCuoi);
            this.grpChucNang.Controls.Add(this.btnXoaPhanTuDau);
            this.grpChucNang.Controls.Add(this.btnXoaPhanTuDangChon);
            this.grpChucNang.Controls.Add(this.btnChonSoLeCuoi);
            this.grpChucNang.Controls.Add(this.btnChonSoChanDau);
            this.grpChucNang.Controls.Add(this.btnTangMoiPhanTuLen2);
            this.grpChucNang.Location = new System.Drawing.Point(4, 4);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(297, 223);
            this.grpChucNang.TabIndex = 0;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng";
            // 
            // btnXoaPhanTuCuoi
            // 
            this.btnXoaPhanTuCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhanTuCuoi.Location = new System.Drawing.Point(58, 189);
            this.btnXoaPhanTuCuoi.Name = "btnXoaPhanTuCuoi";
            this.btnXoaPhanTuCuoi.Size = new System.Drawing.Size(192, 28);
            this.btnXoaPhanTuCuoi.TabIndex = 0;
            this.btnXoaPhanTuCuoi.Text = "Xóa phần tử cuối";
            this.btnXoaPhanTuCuoi.UseVisualStyleBackColor = true;
            this.btnXoaPhanTuCuoi.Click += new System.EventHandler(this.btnXoaPhanTuCuoi_Click);
            // 
            // btnXoaPhanTuDau
            // 
            this.btnXoaPhanTuDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhanTuDau.Location = new System.Drawing.Point(58, 155);
            this.btnXoaPhanTuDau.Name = "btnXoaPhanTuDau";
            this.btnXoaPhanTuDau.Size = new System.Drawing.Size(192, 28);
            this.btnXoaPhanTuDau.TabIndex = 0;
            this.btnXoaPhanTuDau.Text = "Xóa phần tử đầu";
            this.btnXoaPhanTuDau.UseVisualStyleBackColor = true;
            this.btnXoaPhanTuDau.Click += new System.EventHandler(this.btnXoaPhanTuDau_Click);
            // 
            // btnXoaPhanTuDangChon
            // 
            this.btnXoaPhanTuDangChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhanTuDangChon.Location = new System.Drawing.Point(58, 121);
            this.btnXoaPhanTuDangChon.Name = "btnXoaPhanTuDangChon";
            this.btnXoaPhanTuDangChon.Size = new System.Drawing.Size(192, 28);
            this.btnXoaPhanTuDangChon.TabIndex = 0;
            this.btnXoaPhanTuDangChon.Text = "Xóa phần tử đang chọn";
            this.btnXoaPhanTuDangChon.UseVisualStyleBackColor = true;
            this.btnXoaPhanTuDangChon.Click += new System.EventHandler(this.btnXoaPhanTuDangChon_Click);
            // 
            // btnChonSoLeCuoi
            // 
            this.btnChonSoLeCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonSoLeCuoi.Location = new System.Drawing.Point(58, 87);
            this.btnChonSoLeCuoi.Name = "btnChonSoLeCuoi";
            this.btnChonSoLeCuoi.Size = new System.Drawing.Size(192, 28);
            this.btnChonSoLeCuoi.TabIndex = 0;
            this.btnChonSoLeCuoi.Text = "Chọn số lẻ cuối";
            this.btnChonSoLeCuoi.UseVisualStyleBackColor = true;
            this.btnChonSoLeCuoi.Click += new System.EventHandler(this.btnChonSoLeCuoi_Click);
            // 
            // btnChonSoChanDau
            // 
            this.btnChonSoChanDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonSoChanDau.Location = new System.Drawing.Point(58, 53);
            this.btnChonSoChanDau.Name = "btnChonSoChanDau";
            this.btnChonSoChanDau.Size = new System.Drawing.Size(192, 28);
            this.btnChonSoChanDau.TabIndex = 0;
            this.btnChonSoChanDau.Text = "Chọn số chẵn đầu";
            this.btnChonSoChanDau.UseVisualStyleBackColor = true;
            this.btnChonSoChanDau.Click += new System.EventHandler(this.btnChonSoChanDau_Click);
            // 
            // btnTangMoiPhanTuLen2
            // 
            this.btnTangMoiPhanTuLen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTangMoiPhanTuLen2.Location = new System.Drawing.Point(58, 19);
            this.btnTangMoiPhanTuLen2.Name = "btnTangMoiPhanTuLen2";
            this.btnTangMoiPhanTuLen2.Size = new System.Drawing.Size(192, 28);
            this.btnTangMoiPhanTuLen2.TabIndex = 0;
            this.btnTangMoiPhanTuLen2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTangMoiPhanTuLen2.UseVisualStyleBackColor = true;
            this.btnTangMoiPhanTuLen2.Click += new System.EventHandler(this.btnTangMoiPhanTuLen2_Click);
            // 
            // btnKetThucUngDung
            // 
            this.btnKetThucUngDung.BackColor = System.Drawing.Color.Red;
            this.btnKetThucUngDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetThucUngDung.ForeColor = System.Drawing.Color.White;
            this.btnKetThucUngDung.Location = new System.Drawing.Point(30, 418);
            this.btnKetThucUngDung.Name = "btnKetThucUngDung";
            this.btnKetThucUngDung.Size = new System.Drawing.Size(174, 31);
            this.btnKetThucUngDung.TabIndex = 3;
            this.btnKetThucUngDung.Text = "Kết thúc ứng dụng";
            this.btnKetThucUngDung.UseVisualStyleBackColor = false;
            this.btnKetThucUngDung.Click += new System.EventHandler(this.btnKetThucUngDung_Click);
            // 
            // btnXoaDaySo
            // 
            this.btnXoaDaySo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXoaDaySo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDaySo.ForeColor = System.Drawing.Color.White;
            this.btnXoaDaySo.Location = new System.Drawing.Point(287, 418);
            this.btnXoaDaySo.Name = "btnXoaDaySo";
            this.btnXoaDaySo.Size = new System.Drawing.Size(174, 31);
            this.btnXoaDaySo.TabIndex = 3;
            this.btnXoaDaySo.Text = "Xóa dãy số";
            this.btnXoaDaySo.UseVisualStyleBackColor = false;
            this.btnXoaDaySo.Click += new System.EventHandler(this.btnXoaDaySo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 457);
            this.Controls.Add(this.btnXoaDaySo);
            this.Controls.Add(this.btnKetThucUngDung);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.grpNhapSoNguyen);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ứng dụng xử lý dãy số";
            this.grpNhapSoNguyen.ResumeLayout(false);
            this.grpNhapSoNguyen.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpNhapSoNguyen;
        private System.Windows.Forms.TextBox txtNhapSoNguyen;
        private System.Windows.Forms.Button btnNhapSo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.ListBox lsbDaySo;
        private System.Windows.Forms.Button btnTangMoiPhanTuLen2;
        private System.Windows.Forms.Button btnXoaPhanTuCuoi;
        private System.Windows.Forms.Button btnXoaPhanTuDau;
        private System.Windows.Forms.Button btnXoaPhanTuDangChon;
        private System.Windows.Forms.Button btnChonSoLeCuoi;
        private System.Windows.Forms.Button btnChonSoChanDau;
        private System.Windows.Forms.Button btnKetThucUngDung;
        private System.Windows.Forms.Button btnXoaDaySo;
    }
}

