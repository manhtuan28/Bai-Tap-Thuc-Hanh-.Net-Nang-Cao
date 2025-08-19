using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace TinhTienHocTrungTam
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            dateTimeNgayDangKy.Format = DateTimePickerFormat.Custom; // ChatGPT
            dateTimeNgayDangKy.CustomFormat = "dd/MM/yyyy"; // ChatGPT
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult cancel = MessageBox.Show("Bạn chắc chắn muốn hủy?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cancel == DialogResult.Yes)
            {
                rdbtnNam.Checked = false;
                rdbtnNu.Checked = false;
                ckbTiengAnhA.Checked = false;
                ckbTiengAnhB.Checked = false;
                ckbTinHocA.Checked = false;
                ckbTinHocB.Checked = false;
                txtHoTen.Clear();
                txtTongTien.Clear();
                txtThongTin.Clear();
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            string maHoVien = cbbMaHocVien.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string gioiTinh = rdbtnNam.Checked ? "Nam" : "Nữ";
            string ngayDK = dateTimeNgayDangKy.Value.ToString("dd/MM/yyyy");

            int s = 0;

            if (ckbTinHocA.Checked)
                s += int.Parse(lblTinhHocA.Text.Split('.')[0]);
            if (ckbTinHocB.Checked)
                s += int.Parse(lblTinhHocB.Text.Split('.')[0]);
            if (ckbTiengAnhA.Checked)
                s += int.Parse(lblTiengAnhA.Text.Split('.')[0]);
            if (ckbTiengAnhB.Checked) 
                s += int.Parse(lblTiengAnhB.Text.Split('.')[0]);
            this.txtTongTien.Text = s + ".000 đồng";

            txtThongTin.Text =
                "Mã học viên: " + maHoVien + Environment.NewLine +
                "Họ Tên: " + hoTen + Environment.NewLine +
                "Giới Tính: " + gioiTinh + Environment.NewLine +
                "Ngày đăng ký: " + ngayDK;
        }
    }
}
// Code By Tuancute
