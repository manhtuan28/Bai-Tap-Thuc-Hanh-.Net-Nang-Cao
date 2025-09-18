using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace TH4_BT2
{
    public partial class Form1 : Form
    {
        private readonly QL_NHANVIENEntities db = new QL_NHANVIENEntities();

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                dataGridView.AutoGenerateColumns = false;

                if (dataGridView.Columns["colMaCV"] != null)
                    dataGridView.Columns["colMaCV"].DataPropertyName = "macv";
                if (dataGridView.Columns["colTenCV"] != null)
                    dataGridView.Columns["colTenCV"].DataPropertyName = "tencv";
                if (dataGridView.Columns["colHsPhuCap"] != null)
                    dataGridView.Columns["colHsPhuCap"].DataPropertyName = "hsphucap";

                var list = db.chucvus
                             .AsNoTracking()
                             .OrderBy(x => x.macv)
                             .ToList();

                dataGridView.DataSource = list;
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out string macv, out string tencv, out decimal hs)) return;

            try
            {
                if (db.chucvus.Any(x => x.macv == macv))
                {
                    MessageBox.Show("Mã chức vụ đã tồn tại!", "Trùng mã",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var cv = new chucvu { macv = macv, tencv = tencv, hsphucap = hs };
                db.chucvus.Add(cv);
                db.SaveChanges();

                LoadData();
                ClearInputs();
                MessageBox.Show("Đã thêm chức vụ", "OK",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out string macv, out string tencv, out decimal hs)) return;

            try
            {
                var cv = db.chucvus.FirstOrDefault(x => x.macv == macv);
                if (cv == null)
                {
                    MessageBox.Show("Không tìm thấy chức vụ để sửa!", "Không tồn tại",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cv.tencv = tencv;
                cv.hsphucap = hs;
                db.SaveChanges();

                LoadData();
                ClearInputs();
                MessageBox.Show("Đã cập nhật", "OK",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            var macv = (txtMaChucVu.Text ?? "").Trim();
            if (macv.Length == 0)
            {
                MessageBox.Show("Hãy chọn mã chức vụ cần xóa!", "Thiếu dữ liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Xóa chức vụ này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                var cv = db.chucvus.FirstOrDefault(x => x.macv == macv);
                if (cv == null)
                {
                    MessageBox.Show("Không tìm thấy chức vụ để xóa!", "Không tồn tại",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                db.chucvus.Remove(cv);
                db.SaveChanges();

                LoadData();
                ClearInputs();
                MessageBox.Show("Đã xóa", "OK",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Không thể xóa vì chức vụ đang được sử dụng ở bảng Nhân viên.",
                                "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView.Rows[e.RowIndex];
            txtMaChucVu.Text = row.Cells["colMaCV"]?.Value?.ToString();
            txtTenChucVu.Text = row.Cells["colTenCV"]?.Value?.ToString();
            txtHeSoPhuCap.Text = row.Cells["colHsPhuCap"]?.Value?.ToString();

            txtMaChucVu.ReadOnly = true;
        }
        private bool ValidateInput(out string macv, out string tencv, out decimal hs)
        {
            macv = (txtMaChucVu.Text ?? "").Trim();
            tencv = (txtTenChucVu.Text ?? "").Trim();
            hs = 0m;

            if (macv.Length == 0)
            {
                MessageBox.Show("Mã chức vụ không được để trống!");
                return false;
            }
            if (tencv.Length == 0)
            {
                MessageBox.Show("Tên chức vụ không được để trống!");
                return false;
            }
            if (!decimal.TryParse(txtHeSoPhuCap.Text, out hs))
            {
                MessageBox.Show("Hệ số phụ cấp phải là số!");
                return false;
            }
            return true;
        }

        private void ClearInputs()
        {
            txtMaChucVu.ReadOnly = false;
            txtMaChucVu.Clear();
            txtTenChucVu.Clear();
            txtHeSoPhuCap.Clear();
            txtMaChucVu.Focus();
        }

        private void quảnLýPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
