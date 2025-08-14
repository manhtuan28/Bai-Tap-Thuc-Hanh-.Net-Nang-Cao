using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuViDienTichHinhChuNhat
{
    public partial class ChuViDienTichHinhChuNhat : Form
    {
        public ChuViDienTichHinhChuNhat()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtChieuDai.Text);
                double b = double.Parse(txtChieuRong.Text);

                double C = (a + b) * 2;
                double S = a * b;

                txtChuVi.Text = C.ToString();
                txtDienTich.Text = S.ToString();
            }
            catch (FormatException) 
            {
                MessageBox.Show("Chiều dài hoặc chiều rộng không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            DialogResult reset = MessageBox.Show("Bạn có chắc chắn muốn làm lại?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (reset == DialogResult.Yes) 
            {
                txtChieuDai.Clear();
                txtChieuRong.Clear();
                txtChuVi.Clear();
                txtDienTich.Clear();
            }
        }

        private void txtChieuDai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtChieuRong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if(e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
// Code by Tuancute