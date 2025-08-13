using System;
using System.Windows.Forms;

namespace BaiTapThucHanh
{
    public partial class BT1 : Form
    {
        public BT1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                double r = double.Parse(txtBanKinh.Text);

                double C = 2 * Math.PI * r;
                double S = Math.PI * Math.Pow(r, 2);

                txtChuVi.Text = C.ToString("0.00");
                txtDienTich.Text = S.ToString("0.00");
            }
            catch (FormatException) 
            {
                MessageBox.Show("Bán kính không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtBanKinh.Clear();
            txtChuVi.Clear();
            txtDienTich.Clear();
        }
    }
}
// Code By Tuancute