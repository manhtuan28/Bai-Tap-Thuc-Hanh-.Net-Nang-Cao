using System;
using System.Globalization;
using System.Windows.Forms;

namespace BTH3_BT1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            var reset = MessageBox.Show("Bạn có chắc muốn làm lại?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (reset == DialogResult.Yes)
            {
                txtA.Clear();
                txtB.Clear();
                txtKetQua.Clear();
                txtA.Focus();
            }
        }

        private static bool TryParseNumber(string s, out double v)
        {
            s = (s ?? "").Trim().Replace(',', '.');
            return double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out v);
        }

        private void btnGiaiPhuongTrinh_Click(object sender, EventArgs e)
        {
            if (!TryParseNumber(txtA.Text, out double a) ||
                !TryParseNumber(txtB.Text, out double b))
            {
                MessageBox.Show("Nhập số hợp lệ cho a và b.");
                return;
            }

            var pt = new PTB1(a, b);
            var (status, x) = pt.Solve();

            switch (status)
            {
                case PTB1Status.InfiniteSolutions:
                    txtKetQua.Text = "Vô số nghiệm.";
                    break;
                case PTB1Status.NoSolution:
                    txtKetQua.Text = "Vô nghiệm.";
                    break;
                case PTB1Status.OneSolution:
                    txtKetQua.Text = "Phương trình có nghiệm: x = " + x.Value.ToString("0.######", new CultureInfo("vi-VN"));
                    break;
            }
        }
    }
}
