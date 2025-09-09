namespace XepLoaiHocTap
{
    partial class frmXepLoaiHocTap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXepLoaiHocTap));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDiemHKI = new System.Windows.Forms.Label();
            this.txtDiemHKI = new System.Windows.Forms.TextBox();
            this.lblDiemHKII = new System.Windows.Forms.Label();
            this.txtDiemHKII = new System.Windows.Forms.TextBox();
            this.lblXepLoai = new System.Windows.Forms.Label();
            this.txtXepLoai = new System.Windows.Forms.TextBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 69);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "XẾP LOẠI HỌC TẬP";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiemHKI
            // 
            this.lblDiemHKI.AutoSize = true;
            this.lblDiemHKI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemHKI.Location = new System.Drawing.Point(24, 92);
            this.lblDiemHKI.Name = "lblDiemHKI";
            this.lblDiemHKI.Size = new System.Drawing.Size(77, 20);
            this.lblDiemHKI.TabIndex = 1;
            this.lblDiemHKI.Text = "Điểm HKI";
            // 
            // txtDiemHKI
            // 
            this.txtDiemHKI.Location = new System.Drawing.Point(112, 94);
            this.txtDiemHKI.Name = "txtDiemHKI";
            this.txtDiemHKI.Size = new System.Drawing.Size(179, 20);
            this.txtDiemHKI.TabIndex = 0;
            this.txtDiemHKI.TextChanged += new System.EventHandler(this.txtDiemHKI_TextChanged);
            this.txtDiemHKI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiemHKI_KeyPress);
            // 
            // lblDiemHKII
            // 
            this.lblDiemHKII.AutoSize = true;
            this.lblDiemHKII.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemHKII.Location = new System.Drawing.Point(24, 132);
            this.lblDiemHKII.Name = "lblDiemHKII";
            this.lblDiemHKII.Size = new System.Drawing.Size(82, 20);
            this.lblDiemHKII.TabIndex = 1;
            this.lblDiemHKII.Text = "Điểm HKII";
            // 
            // txtDiemHKII
            // 
            this.txtDiemHKII.Location = new System.Drawing.Point(112, 134);
            this.txtDiemHKII.Name = "txtDiemHKII";
            this.txtDiemHKII.Size = new System.Drawing.Size(179, 20);
            this.txtDiemHKII.TabIndex = 1;
            this.txtDiemHKII.TextChanged += new System.EventHandler(this.txtDiemHKII_TextChanged);
            this.txtDiemHKII.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiemHKII_KeyPress);
            // 
            // lblXepLoai
            // 
            this.lblXepLoai.AutoSize = true;
            this.lblXepLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXepLoai.Location = new System.Drawing.Point(24, 175);
            this.lblXepLoai.Name = "lblXepLoai";
            this.lblXepLoai.Size = new System.Drawing.Size(66, 20);
            this.lblXepLoai.TabIndex = 1;
            this.lblXepLoai.Text = "Xếp loại";
            // 
            // txtXepLoai
            // 
            this.txtXepLoai.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtXepLoai.Location = new System.Drawing.Point(112, 175);
            this.txtXepLoai.Name = "txtXepLoai";
            this.txtXepLoai.ReadOnly = true;
            this.txtXepLoai.Size = new System.Drawing.Size(179, 20);
            this.txtXepLoai.TabIndex = 2;
            // 
            // btnDongY
            // 
            this.btnDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.Location = new System.Drawing.Point(28, 224);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(116, 27);
            this.btnDongY.TabIndex = 3;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamLai.Location = new System.Drawing.Point(175, 224);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(116, 27);
            this.btnLamLai.TabIndex = 4;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // frmXepLoaiHocTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 276);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtXepLoai);
            this.Controls.Add(this.lblXepLoai);
            this.Controls.Add(this.txtDiemHKII);
            this.Controls.Add(this.lblDiemHKII);
            this.Controls.Add(this.txtDiemHKI);
            this.Controls.Add(this.lblDiemHKI);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmXepLoaiHocTap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xếp loại học tập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDiemHKI;
        private System.Windows.Forms.TextBox txtDiemHKI;
        private System.Windows.Forms.Label lblDiemHKII;
        private System.Windows.Forms.TextBox txtDiemHKII;
        private System.Windows.Forms.Label lblXepLoai;
        private System.Windows.Forms.TextBox txtXepLoai;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnLamLai;
    }
}

