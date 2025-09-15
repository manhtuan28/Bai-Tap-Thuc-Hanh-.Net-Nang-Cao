using System;
using System.Collections.Generic;
using System.Text;

namespace TH3_BT3
{
    public class HoaDon
    {
        public string SoHoaDon { get; }
        public DateTime NgayLap { get; }
        public string KhachHang { get; }
        public List<SanPham> ChiTiet { get; } = new List<SanPham>();

        public HoaDon(string soHd, DateTime ngayLap, string khachHang)
        {
            if (string.IsNullOrWhiteSpace(soHd)) throw new ArgumentException("Số hóa đơn không được rỗng.");
            if (string.IsNullOrWhiteSpace(khachHang)) throw new ArgumentException("Khách hàng không được rỗng.");
            SoHoaDon = soHd.Trim();
            NgayLap = ngayLap;
            KhachHang = khachHang.Trim();
        }

        public decimal TongTien
        {
            get
            {
                decimal sum = 0;
                foreach (var sp in ChiTiet) sum += sp.ThanhTien;
                return sum;
            }
        }

        public string ToReportString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Hóa đơn: {SoHoaDon}");
            sb.AppendLine($"Ngày lập hóa đơn: {NgayLap:MM/dd/yyyy}");
            sb.AppendLine($"Khách hàng: {KhachHang}");
            sb.AppendLine("Chi tiết hóa đơn:");
            sb.AppendLine($"{"Sản phẩm",-18}{"Đơn giá",10}{"Số lượng",10}{"Thành tiền",14}");
            foreach (var sp in ChiTiet)
            {
                sb.AppendLine($"{sp.Ten,-18}{sp.DonGia,10:0}{"",0}{sp.SoLuong,10}{sp.ThanhTien,14:0}");
            }
            sb.AppendLine($"Tổng trị giá hóa đơn: {TongTien:0}");
            return sb.ToString();
        }
    }
}
