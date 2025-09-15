using System;

namespace TH3_BT3
{
    public class SanPham
    {
        public string Ten { get; }
        public decimal DonGia { get; }
        public int SoLuong { get; }

        public SanPham(string ten, decimal donGia, int soLuong)
        {
            if (string.IsNullOrWhiteSpace(ten)) throw new ArgumentException("Tên sản phẩm không được rỗng.");
            if (donGia < 0) throw new ArgumentException("Đơn giá không hợp lệ.");
            if (soLuong <= 0) throw new ArgumentException("Số lượng phải > 0.");
            Ten = ten.Trim();
            DonGia = donGia;
            SoLuong = soLuong;
        }

        public decimal ThanhTien => SoLuong * DonGia;
    }
}
