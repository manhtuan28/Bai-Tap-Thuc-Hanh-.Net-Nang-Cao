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

        private void btnSoSanh2PhanSo_Click(object sender, EventArgs e)
        {
            PhanSo a, b;

            if (!PhanSo.TryParse(txtPhanSo1.Text, out a))
            {
                MessageBox.Show("Phân số 1 không hợp lệ. Nhập dạng a/b hoặc số nguyên.", "Thông báo");
                txtPhanSo1.Focus(); return;
            }
            if (!PhanSo.TryParse(txtPhanSo2.Text, out b))
            {
                MessageBox.Show("Phân số 2 không hợp lệ. Nhập dạng a/b hoặc số nguyên.", "Thông báo");
                txtPhanSo2.Focus(); return;
            }

            int cmp = PhanSo.SoSanh(a, b);
            string msg = (cmp == 0)
                ? "Hai phân số BẰNG nhau"
                : (cmp > 0 ? "Phân số 1 LỚN hơn phân số 2" : "Phân số 1 NHỎ hơn phân số 2");

            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
