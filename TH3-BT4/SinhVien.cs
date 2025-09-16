using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH3_BT4
{
    public class SinhVien
    {
        private string _ma;
        private string _ten;
        private DateTime _ngaySinh;
        public string Ma
        {
            get => _ma;
            set => _ma = (value ?? "").Trim();
        }

        public string Ten
        {
            get => _ten;
            set => _ten = (value ?? "").Trim();
        }

        public DateTime NgaySinh
        {
            get => _ngaySinh;
            set => _ngaySinh = value;
        }
        public SinhVien() { }

        public SinhVien(string ma, string ten, DateTime ngaySinh)
        {
            Ma = ma;
            Ten = ten;
            NgaySinh = ngaySinh;
        }
        public override string ToString()
        {
            return Ma + "-" + Ten + "-" + NgaySinh.ToString("dd/MM/yyyy");
        }
        public static bool TryParse(string line, out SinhVien sv)
        {
            sv = null;
            if (string.IsNullOrWhiteSpace(line)) return false;
            var parts = line.Split('|');
            if (parts.Length != 3) return false;

            if (!DateTime.TryParseExact(parts[2], "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out DateTime ns))
                return false;

            sv = new SinhVien(parts[0], parts[1], ns);
            return true;
        }
        public string ToDataLine()
            => $"{Ma}|{Ten}|{NgaySinh:dd/MM/yyyy}";
    }
}
