using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TH2_BT5
{
    public partial class frmMain : Form
    {
        string DataPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CongNgheNET.txt");
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadFileToListView();
        }

        private void LoadFileToListView()
        {
            lviCongNgheNET.Items.Clear();

            if (!File.Exists(DataPath))
            {
                MessageBox.Show("Không tìm thấy file: " + DataPath, "Thông báo");
                return;
            }

            foreach (var line in File.ReadAllLines(DataPath, Encoding.UTF8)
                                      .Where(s => !string.IsNullOrWhiteSpace(s)))
            {
                var f = line.Split('|');
                if (f.Length < 6) continue;

                var it = new ListViewItem(f[0]);
                it.SubItems.Add(f[1]);
                it.SubItems.Add(f[2]);
                it.SubItems.Add(f[3]);
                it.SubItems.Add(f[4]);
                it.SubItems.Add(f[5]);
                lviCongNgheNET.Items.Add(it);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var toRemove = lviCongNgheNET.Items.Cast<ListViewItem>()
                                   .Where(i => i.Checked).ToList();
            if (toRemove.Count == 0)
            {
                MessageBox.Show("Chưa tick dòng nào nha!", "Nhắc nhẹ");
                return;
            }

            foreach (var it in toRemove) lviCongNgheNET.Items.Remove(it);

            SaveListViewToFile();
        }

        private void SaveListViewToFile()
        {
            var lines = lviCongNgheNET.Items.Cast<ListViewItem>()
                .Select(it => string.Join("|", new[]
                {
                    it.SubItems[0].Text, it.SubItems[1].Text, it.SubItems[2].Text,
                    it.SubItems[3].Text, it.SubItems[4].Text, it.SubItems[5].Text
                }));
            File.WriteAllLines(DataPath, lines, Encoding.UTF8);
        }

        private void lviCongNgheNET_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lviCongNgheNET.SelectedItems.Count == 0) return;
            FillTextBoxes(lviCongNgheNET.SelectedItems[0]);
        }

        private void lviCongNgheNET_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var item = lviCongNgheNET.Items[e.Index];
            BeginInvoke(new Action(() => FillTextBoxes(item)));
        }

        private void FillTextBoxes(ListViewItem it)
        {
            if (it == null || it.SubItems.Count < 6) return;

            txtMaSV.Text = it.SubItems[0].Text;
            txtTenSV.Text = it.SubItems[1].Text;
            txtLop.Text = it.SubItems[2].Text;
            mkNgaySinh.Text = it.SubItems[3].Text;
            txtGioiTinh.Text = it.SubItems[4].Text;
            txtQueQuan.Text = it.SubItems[5].Text;
        }
    }
}
