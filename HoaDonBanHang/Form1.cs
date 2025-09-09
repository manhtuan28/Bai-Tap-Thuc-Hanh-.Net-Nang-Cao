using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoaDonBanHang
{
    public partial class Form1 : Form
    {
        int thanhTien = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int soLuong = int.Parse(txtSoLuong.Text);
            int donGia = int.Parse(txtDonGia.Text);
            thanhTien = soLuong * donGia;
            txtThanhTien.Text = thanhTien.ToString();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            double giamGia = 0;
            txtTongChuaThue.Text = thanhTien.ToString();

            double thue = (thanhTien * 10) / 100.0;
            txtThue.Text = thue.ToString();

            if (chkKHTT.Checked)
            {
                giamGia = (thanhTien * 5) / 100.0;
            }

            txtGiamGia.Text = giamGia.ToString();
            txtTongTienTra.Text = (thanhTien + thue - giamGia).ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult th = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (th == DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }
        }
        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtTenHang.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtThanhTien.Clear();
            txtTenHang.Focus();
        }

        private void btnKhachHangMoi_Click(object sender, EventArgs e)
        {
            txtTongChuaThue.Clear();
            txtThue.Clear();
            txtGiamGia.Clear();
            txtTongTienTra.Clear();
        }
    }
}
