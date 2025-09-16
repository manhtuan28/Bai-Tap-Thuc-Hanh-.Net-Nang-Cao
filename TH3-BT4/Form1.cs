using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH3_BT4
{
    public partial class frmMain : Form
    {
        private readonly List<SinhVien> _ds = new List<SinhVien>();
        private readonly string _dataPath =
            Path.Combine(Application.StartupPath, "sinhvien.txt");

        public frmMain()
        {
            InitializeComponent();

            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";

            txtTen.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) &&
                    !char.IsLetter(e.KeyChar) &&
                    !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }
            };
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            var ma = (txtMa.Text ?? "").Trim();
            var ten = (txtTen.Text ?? "").Trim();
            var ns = dtpNgaySinh.Value.Date;

            if (string.IsNullOrWhiteSpace(ma))
            {
                MessageBox.Show("Mã không được trống", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa.Focus(); return;
            }
            if (_ds.Any(x => x.Ma.Equals(ma, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã đã tồn tại trong danh sách", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa.Focus(); return;
            }
            if (string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("Tên không được trống", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus(); return;
            }

            var sv = new SinhVien(ma, ten, ns);
            _ds.Add(sv);

            RefreshListBox();

            txtMa.Clear();
            txtTen.Clear();
            txtMa.Focus();
        }

        private void btnLuuSV_Click(object sender, EventArgs e)
        {
            try
            {
                var lines = _ds.Select(x => x.ToDataLine()).ToArray();
                File.WriteAllLines(_dataPath, lines, new UTF8Encoding(false));
                MessageBox.Show("Đã lưu danh sách", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu file: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDocSV_Click(object sender, EventArgs e)
        {
            try
            {
                _ds.Clear();
                if (File.Exists(_dataPath))
                {
                    foreach (var line in File.ReadAllLines(_dataPath, Encoding.UTF8))
                    {
                        if (SinhVien.TryParse(line, out var sv))
                            _ds.Add(sv);
                    }
                }
                RefreshListBox();
                MessageBox.Show("Đã đọc danh sách", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshListBox()
        {
            lstSV.BeginUpdate();
            lstSV.Items.Clear();
            for (int i = 0; i < _ds.Count; i++)
            {
                var sv = _ds[i];
                lstSV.Items.Add($"{i + 1}-{sv.ToString()}");
            }
            lstSV.EndUpdate();
        }
    }
}
