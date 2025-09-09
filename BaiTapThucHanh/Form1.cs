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
            DialogResult reset = MessageBox.Show("Bạn có chắc chắn muốn làm lại?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (reset == DialogResult.Yes) 
            {
                txtBanKinh.Clear();
                txtChuVi.Clear();
                txtDienTich.Clear();
            }
        }

        private void txtBanKinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
// Code By Tuancute