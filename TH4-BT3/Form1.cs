using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace TH4_BT3
{
    public partial class frmMain : Form
    {
        private readonly QL_NHANVIENEntities db = new QL_NHANVIENEntities();

        private enum EditMode { None, Add, Edit }
        private EditMode _mode = EditMode.None;

        public frmMain()
        {
            InitializeComponent();
            LoadData();
            LoadLookups();

            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
        }

        private void LoadLookups()
        {
            var cvs = db.chucvus.AsNoTracking()
                        .OrderBy(x => x.tencv)
                        .Select(x => new { x.macv, x.tencv })
                        .ToList();
            cboChucVu.DataSource = cvs;
            cboChucVu.DisplayMember = "tencv";
            cboChucVu.ValueMember = "macv";
            cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChucVu.SelectedIndex = -1;

            var pbs = db.phongbans.AsNoTracking()
                        .OrderBy(x => x.tenpb)
                        .Select(x => new { x.mapb, x.tenpb })
                        .ToList();
            cboPhongBan.DataSource = pbs;
            cboPhongBan.DisplayMember = "tenpb";
            cboPhongBan.ValueMember = "mapb";
            cboPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhongBan.SelectedIndex = -1;
        }

        private void LoadData()
        {
            try
            {
                dgvQuanLyNhanVien.AutoGenerateColumns = false;

                SetColMap("colMaNhanVien", "manv");
                SetColMap("colHovaLot", "holot");
                SetColMap("colTen", "ten");
                SetColMap("colNgaySinh", "ngaysinh");
                SetColMap("colGioiTinh", "gioitinh");
                SetColMap("colMaCV", "macv");
                SetColMap("colMaPB", "mapb");

                var list = db.nhanviens
                             .AsNoTracking()
                             .OrderBy(x => x.manv)
                             .ToList();

                dgvQuanLyNhanVien.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetColMap(string gridColName, string propertyName)
        {
            var col = dgvQuanLyNhanVien.Columns[gridColName];
            if (col != null) col.DataPropertyName = propertyName;
        }
        private void dgvQuanLyNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvQuanLyNhanVien.Rows[e.RowIndex];

            txtMaNhanVien.Text = row.Cells["colMaNhanVien"]?.Value?.ToString();
            txtHoLot.Text = row.Cells["colHovaLot"]?.Value?.ToString();
            txtTen.Text = row.Cells["colTen"]?.Value?.ToString();

            DateTime dt;
            if (DateTime.TryParse(row.Cells["colNgaySinh"]?.Value?.ToString(), out dt))
                dtpNgaySinh.Value = dt;
            else
                dtpNgaySinh.Value = DateTime.Today;

            var gt = row.Cells["colGioiTinh"]?.Value?.ToString();
            rdoNam.Checked = string.Equals(gt, "Nam", StringComparison.OrdinalIgnoreCase);
            rdoNu.Checked = string.Equals(gt, "Nữ", StringComparison.OrdinalIgnoreCase);

            cboChucVu.SelectedValue = row.Cells["colMaCV"]?.Value?.ToString();
            cboPhongBan.SelectedValue = row.Cells["colMaPB"]?.Value?.ToString();

            SetMode(EditMode.None);
        }

        private void SetMode(EditMode mode)
        {
            _mode = mode;

            bool editing = (mode != EditMode.None);

            txtMaNhanVien.ReadOnly = (mode == EditMode.Edit);
            txtHoLot.ReadOnly = !editing;
            txtTen.ReadOnly = !editing;
            dtpNgaySinh.Enabled = editing;
            rdoNam.Enabled = editing; rdoNu.Enabled = editing;
            cboChucVu.Enabled = editing; cboPhongBan.Enabled = editing;

            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing && !string.IsNullOrWhiteSpace(txtMaNhanVien.Text);
            btnXoa.Enabled = !editing && !string.IsNullOrWhiteSpace(txtMaNhanVien.Text);
            btnLuu.Enabled = editing;
            btnHuy.Enabled = editing;

            if (mode == EditMode.Add) ClearInputs(keepId: false);
        }

        private void ClearInputs(bool keepId)
        {
            if (!keepId) txtMaNhanVien.Clear();
            txtHoLot.Clear();
            txtTen.Clear();
            dtpNgaySinh.Value = DateTime.Today;
            rdoNam.Checked = true; rdoNu.Checked = false;
            cboChucVu.SelectedIndex = -1;
            cboPhongBan.SelectedIndex = -1;
        }

        private bool GetInputs(out string manv, out string holot, out string ten,
                               out DateTime ngaysinh, out string gioitinh,
                               out string macv, out string mapb)
        {
            manv = (txtMaNhanVien.Text ?? "").Trim();
            holot = (txtHoLot.Text ?? "").Trim();
            ten = (txtTen.Text ?? "").Trim();
            ngaysinh = dtpNgaySinh.Value.Date;
            gioitinh = rdoNam.Checked ? "Nam" : "Nữ";
            macv = cboChucVu.SelectedValue?.ToString();
            mapb = cboPhongBan.SelectedValue?.ToString();

            if (string.IsNullOrWhiteSpace(manv))
            { MessageBox.Show("Mã nhân viên không được để trống!"); txtMaNhanVien.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(ten))
            { MessageBox.Show("Tên nhân viên không được để trống!"); txtTen.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(macv))
            { MessageBox.Show("Chưa chọn Chức vụ!"); cboChucVu.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(mapb))
            { MessageBox.Show("Chưa chọn Phòng ban!"); cboPhongBan.Focus(); return false; }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearInputs(keepId: false);
            SetMode(EditMode.Add);
            txtMaNhanVien.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNhanVien.Text))
            { MessageBox.Show("Hãy chọn nhân viên cần sửa!"); return; }

            SetMode(EditMode.Edit);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var manv = (txtMaNhanVien.Text ?? "").Trim();
            if (manv.Length == 0)
            { MessageBox.Show("Hãy chọn nhân viên cần xóa!"); return; }

            if (MessageBox.Show("Xóa nhân viên này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                var nv = db.nhanviens.FirstOrDefault(x => x.manv == manv);
                if (nv == null)
                { MessageBox.Show("Không tìm thấy nhân viên để xóa!"); return; }

                db.nhanviens.Remove(nv);
                db.SaveChanges();

                LoadData();
                ClearInputs(keepId: false);
                SetMode(EditMode.None);
                MessageBox.Show("Đã xóa", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Không thể xóa vì nhân viên đang có dữ liệu liên quan.",
                    "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearInputs(keepId: false);
            SetMode(EditMode.None);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!GetInputs(out string manv, out string holot, out string ten,
               out DateTime ngaysinh, out string gioitinh,
               out string macv, out string mapb)) return;

            try
            {
                if (_mode == EditMode.Add)
                {
                    if (db.nhanviens.Any(x => x.manv == manv))
                    { MessageBox.Show("Mã nhân viên đã tồn tại!"); return; }

                    var nv = new nhanvien
                    {
                        manv = manv,
                        holot = holot,
                        ten = ten,
                        ngaysinh = ngaysinh,
                        gioitinh = gioitinh,
                        macv = macv,
                        mapb = mapb
                    };
                    db.nhanviens.Add(nv);
                }
                else if (_mode == EditMode.Edit)
                {
                    var nv = db.nhanviens.FirstOrDefault(x => x.manv == manv);
                    if (nv == null)
                    { MessageBox.Show("Không tìm thấy nhân viên để cập nhật!"); return; }

                    nv.holot = holot;
                    nv.ten = ten;
                    nv.ngaysinh = ngaysinh;
                    nv.gioitinh = gioitinh;
                    nv.macv = macv;
                    nv.mapb = mapb;
                }
                else
                {
                    MessageBox.Show("Chọn Thêm hoặc Sửa trước khi Lưu!");
                    return;
                }

                db.SaveChanges();
                LoadData();
                SetMode(EditMode.None);
                MessageBox.Show("Đã lưu dữ liệu", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
