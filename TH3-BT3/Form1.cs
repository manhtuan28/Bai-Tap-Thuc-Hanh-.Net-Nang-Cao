using System;
using System.Windows.Forms;

namespace TH3_BT3
{
    public partial class frmMain : Form
    {
        private HoaDon _hoaDon;
        public frmMain()
        {
            InitializeComponent();
            
            DateTime utcTime = DateTime.Now;
            dtpNgayLapHoaDon.Format = DateTimePickerFormat.Custom;
            dtpNgayLapHoaDon.CustomFormat = "dd/MM/yyyy";

            lvChiTiet.FullRowSelect = true;
            lvChiTiet.GridLines = true;
            lvChiTiet.View = View.Details;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtSoHoaDon.Clear();
            txtKhachHang.Clear();
            txtSanPham.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
            lvChiTiet.Items.Clear();
            _hoaDon = null;
            dtpNgayLapHoaDon.Value = DateTime.Now.Date;
            txtSoHoaDon.Focus();
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                var ten = txtSanPham.Text.Trim();
                if (!decimal.TryParse(txtDonGia.Text.Trim(), out var donGia) || donGia < 0)
                {
                    MessageBox.Show("Đơn giá không hợp lệ."); txtDonGia.Focus(); return;
                }
                if (!int.TryParse(txtSoLuong.Text.Trim(), out var soLuong) || soLuong <= 0)
                {
                    MessageBox.Show("Số lượng phải là số nguyên dương."); txtSoLuong.Focus(); return;
                }

                var sp = new SanPham(ten, donGia, soLuong);

                var item = new ListViewItem(sp.Ten);
                item.SubItems.Add(sp.DonGia.ToString("0"));
                item.SubItems.Add(sp.SoLuong.ToString());
                item.SubItems.Add(sp.ThanhTien.ToString("0"));
                lvChiTiet.Items.Add(item);

                EnsureHoaDonCreated();
                _hoaDon.ChiTiet.Add(sp);

                txtSanPham.Clear();
                txtDonGia.Clear();
                txtSoLuong.Clear();
                txtSanPham.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                EnsureHoaDonCreated();

                if (_hoaDon.ChiTiet.Count == 0)
                {
                    MessageBox.Show("Hóa đơn chưa có dòng chi tiết nào.", "Thông báo");
                    return;
                }

                var report = _hoaDon.ToReportString();
                MessageBox.Show(report, "Hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ApplicationException)
            {
                // đã show message trong EnsureHoaDonCreated
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void EnsureHoaDonCreated()
        {
            if (_hoaDon == null)
            {
                if (string.IsNullOrWhiteSpace(txtSoHoaDon.Text))
                { MessageBox.Show("Vui lòng nhập Số hóa đơn."); txtSoHoaDon.Focus(); throw new ApplicationException(); }

                if (string.IsNullOrWhiteSpace(txtKhachHang.Text))
                { MessageBox.Show("Vui lòng nhập Khách hàng."); txtKhachHang.Focus(); throw new ApplicationException(); }

                _hoaDon = new HoaDon(txtSoHoaDon.Text.Trim(), dtpNgayLapHoaDon.Value.Date, txtKhachHang.Text.Trim());
            }
            else
            {
                // nếu người dùng đổi số HĐ/khách hàng sau khi đã thêm chi tiết → cập nhật cho khớp
                _hoaDon = new HoaDon(txtSoHoaDon.Text.Trim(), dtpNgayLapHoaDon.Value.Date, txtKhachHang.Text.Trim())
                {
                    // list cũ
                };
                foreach (ListViewItem it in lvChiTiet.Items)
                {
                    var ten = it.SubItems[0].Text;
                    var donGia = decimal.Parse(it.SubItems[1].Text);
                    var soLuong = int.Parse(it.SubItems[2].Text);
                    _hoaDon.ChiTiet.Add(new SanPham(ten, donGia, soLuong));
                }
            }
        }
    }
}
