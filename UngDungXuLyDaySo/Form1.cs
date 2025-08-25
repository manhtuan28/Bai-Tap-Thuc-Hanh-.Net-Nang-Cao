using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungXuLyDaySo
{
    public partial class frmMain : Form
    {
        private readonly Random _rnd = new Random();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNhapSo_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNhapSoNguyen.Text.Trim(), out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Nhập vào một số nguyên dương!", "Thông báo");
                return;
            }

            lsbDaySo.Items.Clear();

            for (int i = 0; i < soLuong; i++)
            {
                int val = _rnd.Next(1, 101);
                lsbDaySo.Items.Add(val);
            }

            txtNhapSoNguyen.Clear();
            txtNhapSoNguyen.Focus();
        }

        private void btnTangMoiPhanTuLen2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                int val = Convert.ToInt32(lsbDaySo.Items[i]);
                lsbDaySo.Items[i] = val + 2;
            }
        }

        private void btnChonSoChanDau_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                if (Convert.ToInt32(lsbDaySo.Items[i]) % 2 == 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    return;
                }
            }
            MessageBox.Show("Không có số chẵn nào trong dãy.", "Thông báo");
        }

        private void btnChonSoLeCuoi_Click(object sender, EventArgs e)
        {
            for (int i = lsbDaySo.Items.Count - 1; i >= 0; i--)
            {
                if (Math.Abs(Convert.ToInt32(lsbDaySo.Items[i])) % 2 == 1)
                {
                    lsbDaySo.SelectedIndex = i;
                    return;
                }
            }
            MessageBox.Show("Không có số lẻ nào trong dãy.", "Thông báo");
        }

        private void btnXoaPhanTuDangChon_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.SelectedIndex >= 0)
                lsbDaySo.Items.RemoveAt(lsbDaySo.SelectedIndex);
            else
                MessageBox.Show("Chọn 1 phần tử để xóa.","Thông báo");
        }

        private void btnXoaPhanTuDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
                lsbDaySo.Items.RemoveAt(0);
        }

        private void btnXoaPhanTuCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
                lsbDaySo.Items.RemoveAt(lsbDaySo.Items.Count - 1);
        }

        private void btnXoaDaySo_Click(object sender, EventArgs e)
        {
            lsbDaySo.Items.Clear();
        }

        private void btnKetThucUngDung_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (thoat == DialogResult.Yes) 
            { 
                Application.Exit();
            }
        }

        private void txtNhapSoNguyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
