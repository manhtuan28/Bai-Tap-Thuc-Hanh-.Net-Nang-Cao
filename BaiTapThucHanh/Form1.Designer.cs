namespace BaiTapThucHanh
{
    partial class BT1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BT1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBanKinh = new System.Windows.Forms.Label();
            this.lblChuVi = new System.Windows.Forms.Label();
            this.lblDienTich = new System.Windows.Forms.Label();
            this.txtBanKinh = new System.Windows.Forms.TextBox();
            this.txtChuVi = new System.Windows.Forms.TextBox();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(61, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(404, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TÍNH CHU VI, DIỆN TÍCH HÌNH TRÒN";
            // 
            // lblBanKinh
            // 
            this.lblBanKinh.AutoSize = true;
            this.lblBanKinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanKinh.Location = new System.Drawing.Point(63, 110);
            this.lblBanKinh.Name = "lblBanKinh";
            this.lblBanKinh.Size = new System.Drawing.Size(58, 16);
            this.lblBanKinh.TabIndex = 1;
            this.lblBanKinh.Text = "Bán kính";
            // 
            // lblChuVi
            // 
            this.lblChuVi.AutoSize = true;
            this.lblChuVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuVi.Location = new System.Drawing.Point(63, 160);
            this.lblChuVi.Name = "lblChuVi";
            this.lblChuVi.Size = new System.Drawing.Size(43, 16);
            this.lblChuVi.TabIndex = 2;
            this.lblChuVi.Text = "Chu vi";
            // 
            // lblDienTich
            // 
            this.lblDienTich.AutoSize = true;
            this.lblDienTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienTich.Location = new System.Drawing.Point(63, 211);
            this.lblDienTich.Name = "lblDienTich";
            this.lblDienTich.Size = new System.Drawing.Size(58, 16);
            this.lblDienTich.TabIndex = 3;
            this.lblDienTich.Text = "Diện tích";
            // 
            // txtBanKinh
            // 
            this.txtBanKinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanKinh.Location = new System.Drawing.Point(132, 105);
            this.txtBanKinh.Multiline = true;
            this.txtBanKinh.Name = "txtBanKinh";
            this.txtBanKinh.Size = new System.Drawing.Size(333, 27);
            this.txtBanKinh.TabIndex = 4;
            this.txtBanKinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBanKinh_KeyPress);
            // 
            // txtChuVi
            // 
            this.txtChuVi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtChuVi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChuVi.Cursor = System.Windows.Forms.Cursors.No;
            this.txtChuVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuVi.Location = new System.Drawing.Point(132, 156);
            this.txtChuVi.Multiline = true;
            this.txtChuVi.Name = "txtChuVi";
            this.txtChuVi.ReadOnly = true;
            this.txtChuVi.Size = new System.Drawing.Size(333, 27);
            this.txtChuVi.TabIndex = 5;
            this.txtChuVi.UseSystemPasswordChar = true;
            // 
            // txtDienTich
            // 
            this.txtDienTich.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDienTich.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDienTich.Cursor = System.Windows.Forms.Cursors.No;
            this.txtDienTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienTich.Location = new System.Drawing.Point(132, 207);
            this.txtDienTich.Multiline = true;
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.ReadOnly = true;
            this.txtDienTich.Size = new System.Drawing.Size(333, 27);
            this.txtDienTich.TabIndex = 6;
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(101, 263);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(145, 38);
            this.btnTinh.TabIndex = 7;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamLai.Location = new System.Drawing.Point(302, 263);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(145, 38);
            this.btnLamLai.TabIndex = 8;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // BT1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 347);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.txtChuVi);
            this.Controls.Add(this.txtBanKinh);
            this.Controls.Add(this.lblDienTich);
            this.Controls.Add(this.lblChuVi);
            this.Controls.Add(this.lblBanKinh);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BT1";
            this.Text = "Chu Vi Diện, Tích Hình Tròn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBanKinh;
        private System.Windows.Forms.Label lblChuVi;
        private System.Windows.Forms.Label lblDienTich;
        private System.Windows.Forms.TextBox txtBanKinh;
        private System.Windows.Forms.TextBox txtChuVi;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnLamLai;
    }
}