using System;
using System.Windows.Forms;

namespace DanhMucSinhVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (thoat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn 1 dòng để xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);

                txtHoTen.Clear();
                txtLop.Clear();
                txtDiaChi.Clear();
                dateTimeNgaySinh.Value = DateTime.Now;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtLop.Text) || string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            ListViewItem item = new ListViewItem(txtHoTen.Text);
            item.SubItems.Add(dateTimeNgaySinh.Value.ToString("dd/MM/yyyy"));
            item.SubItems.Add(txtLop.Text);
            item.SubItems.Add(txtDiaChi.Text);

            listView1.Items.Add(item);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

                txtHoTen.Text = item.SubItems[0].Text;
                dateTimeNgaySinh.Value = DateTime.ParseExact(item.SubItems[1].Text, "dd/MM/yyyy", null);
                txtLop.Text = item.SubItems[2].Text;
                txtDiaChi.Text = item.SubItems[3].Text;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn 1 dòng để sửa!");
                return;
            }

            ListViewItem item = listView1.SelectedItems[0];

            item.SubItems[0].Text = txtHoTen.Text;
            item.SubItems[1].Text = dateTimeNgaySinh.Value.ToString("dd/MM/yyyy");
            item.SubItems[2].Text = txtLop.Text;
            item.SubItems[3].Text = txtDiaChi.Text;
        }
    }
}
// Code By Tuancute