using System;
using System.Windows.Forms;

namespace TH3_BT2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            txtKetQua.Enabled = false;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtPhanSo1.Clear();
            txtPhanSo2.Clear();
            txtKetQua.Text = "";
            txtPhanSo1.Focus();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            Tinh(PhanSo.Cong);
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            Tinh(PhanSo.Tru);
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            Tinh(PhanSo.Nhan);
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            Tinh(PhanSo.Chia);
        }

        private void Tinh(Func<PhanSo, PhanSo, PhanSo> phepToan)
        {
            if (!PhanSo.TryParse(txtPhanSo1.Text, out var a))
            {
                MessageBox.Show("Phân số 1 không hợp lệ. Nhập dạng a/b hoặc số nguyên.");
                txtPhanSo1.Focus();
                return;
            }

            if (!PhanSo.TryParse(txtPhanSo2.Text, out var b))
            {
                MessageBox.Show("Phân số 2 không hợp lệ. Nhập dạng a/b hoặc số nguyên.");
                txtPhanSo2.Focus();
                return;
            }

            try
            {
                var kq = phepToan(a, b);
                txtKetQua.Text = kq.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }


    }
}
