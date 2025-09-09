using System;
using System.Globalization;
using System.Windows.Forms;

namespace TinhTienDien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Code by ChatGPT
        int TinhTien(int chiSoDau, int chiSoCuoi)
        {
            int soKW = chiSoCuoi - chiSoDau;
            if (soKW <= 0) return 0;

            int tien;

            if (soKW <= 100)
                tien = soKW * 500;
            else if (soKW <= 250)
                tien = 100 * 500 + (soKW - 100) * 600;
            else if (soKW <= 300)
                tien = 100 * 500 + 150 * 600 + (soKW - 250) * 800;
            else
                tien = 100 * 500 + 150 * 600 + 50 * 800 + (soKW - 300) * 1000;

            return tien;
        }
        // End

        private void btnDongY_Click(object sender, EventArgs e)
        {
            int chiSoDau = int.Parse(txtChiSoDau.Text);
            int chiSoCuoi = int.Parse(txtChiSoCuoi.Text);
            int tien = TinhTien(chiSoDau, chiSoCuoi);

            if (chiSoCuoi < chiSoDau)
            {
                MessageBox.Show("Chỉ số cuối phải lớn hơn hoặc bằng chỉ số đầu.");
            }

            var viVN = new CultureInfo("vi-VN"); // ChatGPT
            txtSoTienPhaiDong.Text = tien.ToString("N0",viVN) + " VNĐ"; // ChatGPT
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            DialogResult reset = MessageBox.Show("Bạn có chắc muốn làm lại?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (reset == DialogResult.Yes) 
            {
                txtChiSoDau.Clear();
                txtChiSoCuoi.Clear();
                txtSoTienPhaiDong.Clear();
            }
        }

        private void txtChiSoDau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtChiSoCuoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exxitApp = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exxitApp == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
// Code by Tuancute