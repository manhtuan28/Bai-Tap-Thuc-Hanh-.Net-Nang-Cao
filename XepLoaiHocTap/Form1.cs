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