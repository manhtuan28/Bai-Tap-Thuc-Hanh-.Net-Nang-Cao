using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace TH4_BT2
{
    public partial class Form2 : Form
    {
        private readonly QL_NHANVIENEntities db = new QL_NHANVIENEntities();

        public Form2()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dataGridView.AutoGenerateColumns = false;

                if (dataGridView.Columns["colMaPB"] != null)
                    dataGridView.Columns["colMaPB"].DataPropertyName = "mapb";
                if (dataGridView.Columns["colTenPB"] != null)
                    dataGridView.Columns["colTenPB"].DataPropertyName = "tenpb";

                var list = db.phongbans
                             .AsNoTracking()
                             .OrderBy(x => x.mapb)
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
        private bool ValidateInput(out string mapb, out string tenpb)
        {
            mapb = (txtMaPhongBan.Text ?? "").Trim();
            tenpb = (txtTenPhongBan.Text ?? "").Trim();

            if (mapb.Length == 0)
            {
                MessageBox.Show("Mã phòng ban không được để trống!", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhongBan.Focus();
                return false;
            }
            if (tenpb.Length == 0)
            {
                MessageBox.Show("Tên phòng ban không được để trống!", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPhongBan.Focus();
                return false;
            }
            return true;
        }

        private void ClearInputs()
        {
            txtMaPhongBan.ReadOnly = false;
            txtMaPhongBan.Clear();
            txtTenPhongBan.Clear();
            txtMaPhongBan.Focus();
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView.Rows[e.RowIndex];
            txtMaPhongBan.Text = row.Cells["colMaPB"]?.Value?.ToString();
            txtTenPhongBan.Text = row.Cells["colTenPB"]?.Value?.ToString();

            txtMaPhongBan.ReadOnly = true;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out string mapb, out string tenpb)) return;

            try
            {
                bool exists = db.phongbans.AsNoTracking().Any(x => x.mapb == mapb);
                if (exists)
                {
                    MessageBox.Show("Mã phòng ban đã tồn tại!", "Trùng mã",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var pb = new phongban { mapb = mapb, tenpb = tenpb };
                db.phongbans.Add(pb);
                db.SaveChanges();

                LoadData();
                ClearInputs();
                MessageBox.Show("Đã thêm phòng ban", "OK",
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
            if (!ValidateInput(out string mapb, out string tenpb)) return;

            try
            {
                var pb = db.phongbans.FirstOrDefault(x => x.mapb == mapb);
                if (pb == null)
                {
                    MessageBox.Show("Không tìm thấy phòng ban để sửa!", "Không tồn tại",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                pb.tenpb = tenpb;
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
            var mapb = (txtMaPhongBan.Text ?? "").Trim();
            if (mapb.Length == 0)
            {
                MessageBox.Show("Hãy chọn mã phòng ban cần xóa!", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Xóa phòng ban này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                var pb = db.phongbans.FirstOrDefault(x => x.mapb == mapb);
                if (pb == null)
                {
                    MessageBox.Show("Không tìm thấy phòng ban để xóa!", "Không tồn tại",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                db.phongbans.Remove(pb);
                db.SaveChanges();

                LoadData();
                ClearInputs();
                MessageBox.Show("Đã xóa", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Không thể xóa vì phòng ban đang được sử dụng ở bảng Nhân viên.",
                    "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
