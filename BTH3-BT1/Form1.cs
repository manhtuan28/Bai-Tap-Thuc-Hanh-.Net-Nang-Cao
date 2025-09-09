using System;
using System.Globalization;
using System.Windows.Forms;

namespace BTH3_BT1
{
    public partial class frmMain : Form
    {
        const double EPS = 1e-12;

        public frmMain() => InitializeComponent();

        static double Parse(string s, out bool ok)
        {
            s = (s ?? "").Trim().Replace(',', '.');
            ok = double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out double v);
            return v;
        }

        static string F(double v) => v.ToString("0.######", new CultureInfo("vi-VN"));

        void btnGiaiPT_Click(object sender, EventArgs e)
        {
            double a = Parse(txtA.Text, out bool okA);
            double b = Parse(txtB.Text, out bool okB);
            if (!okA || !okB)
            {
                MessageBox.Show("Nhập số hợp lệ cho a và b.", "Sai định dạng",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Math.Abs(a) <= EPS)
            {
                txtNghiem.Text = Math.Abs(b) <= EPS ? "Vô số nghiệm." : "Vô nghiệm.";
                return;
            }

            txtNghiem.Text = "Phương trình có nghiệm: x = " + F(-b / a);
        }

        void btnLamLai_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtNghiem.Clear();
            txtA.Focus();
        }
    }
}
