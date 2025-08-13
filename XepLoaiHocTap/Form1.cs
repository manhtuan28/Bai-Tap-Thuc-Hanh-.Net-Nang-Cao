using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XepLoaiHocTap
{
    public partial class frmXepLoaiHocTap : Form
    {
        public frmXepLoaiHocTap()
        {
            InitializeComponent();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            double hki = double.Parse(txtDiemHKI.Text);
            double hkii = double.Parse(txtDiemHKII.Text);
            double resultDiem = (hki + 2 * hkii) / 3;

            if (resultDiem >= 9.0)
            {
                txtXepLoai.Text = "Xuất sắc";
            }
            else if (resultDiem >= 8.0)
            {
                txtXepLoai.Text = "Giỏi";
            }
            else if (resultDiem >= 6.5)
            {
                txtXepLoai.Text = "Khá";
            }
            else if (resultDiem >= 5.0)
            {
                txtXepLoai.Text = "Trung bình";
            }
            else if (resultDiem >= 3.5)
            {
                txtXepLoai.Text = "Yếu";
            }
            else
            {
                txtXepLoai.Text = "Kém";
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            DialogResult lamLai = MessageBox.Show(
                "Bạn có chắn chắn?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if(lamLai == DialogResult.Yes)
            {
                txtDiemHKI.Clear();
                txtDiemHKII.Clear();
                txtXepLoai.Clear();
            }
        }
    }
}
// Code by Tuancute