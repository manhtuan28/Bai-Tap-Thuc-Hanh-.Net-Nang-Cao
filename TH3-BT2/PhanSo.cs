using System;

namespace TH3_BT2
{
    public class PhanSo : IEquatable<PhanSo>, IComparable<PhanSo>
    {
        public long Tu { get; private set; }
        public long Mau { get; private set; }

        public PhanSo(long tu, long mau = 1)
        {
            if (mau == 0) throw new DivideByZeroException("Mẫu số không được bằng 0.");
            if (mau < 0) { tu = -tu; mau = -mau; }
            long g = GCD(Math.Abs(tu), mau);
            Tu = tu / g; Mau = mau / g;
        }
        public static PhanSo Cong(PhanSo a, PhanSo b) => new PhanSo(a.Tu * b.Mau + b.Tu * a.Mau, a.Mau * b.Mau);
        public static PhanSo Tru(PhanSo a, PhanSo b) => new PhanSo(a.Tu * b.Mau - b.Tu * a.Mau, a.Mau * b.Mau);
        public static PhanSo Nhan(PhanSo a, PhanSo b) => new PhanSo(a.Tu * b.Tu, a.Mau * b.Mau);
        public static PhanSo Chia(PhanSo a, PhanSo b)
        {
            if (b.Tu == 0) throw new DivideByZeroException("Không thể chia cho 0.");
            long tu = a.Tu * b.Mau, mau = a.Mau * b.Tu;
            if (mau < 0) { tu = -tu; mau = -mau; }
            return new PhanSo(tu, mau);
        }
        public int CompareTo(PhanSo other)
        {
            if (other == null) return 1;
            long left = this.Tu * other.Mau;
            long right = other.Tu * this.Mau;
            return left.CompareTo(right);
        }
        public static int SoSanh(PhanSo a, PhanSo b) => a.CompareTo(b);

        public override string ToString() => Mau == 1 ? $"{Tu}" : $"{Tu}/{Mau}";

        public bool Equals(PhanSo other) => other != null && Tu == other.Tu && Mau == other.Mau;
        public override bool Equals(object obj) => Equals(obj as PhanSo);
        public override int GetHashCode() => Tuple.Create(Tu, Mau).GetHashCode();

        public static bool operator ==(PhanSo a, PhanSo b) => ReferenceEquals(a, b) || (!(a is null) && a.Equals(b));
        public static bool operator !=(PhanSo a, PhanSo b) => !(a == b);
        public static bool operator <(PhanSo a, PhanSo b) => a.CompareTo(b) < 0;
        public static bool operator >(PhanSo a, PhanSo b) => a.CompareTo(b) > 0;
        public static bool operator <=(PhanSo a, PhanSo b) => a.CompareTo(b) <= 0;
        public static bool operator >=(PhanSo a, PhanSo b) => a.CompareTo(b) >= 0;

        public static bool TryParse(string s, out PhanSo result)
        {
            result = null;
            if (string.IsNullOrWhiteSpace(s)) return false;
            var parts = s.Trim().Split('/');
            try
            {
                if (parts.Length == 1)
                {
                    long tu;
                    if (!long.TryParse(parts[0], out tu)) return false;
                    result = new PhanSo(tu, 1); return true;
                }
                if (parts.Length == 2)
                {
                    long tu, mau;
                    if (!long.TryParse(parts[0], out tu)) return false;
                    if (!long.TryParse(parts[1], out mau)) return false;
                    result = new PhanSo(tu, mau); return true;
                }
                return false;
            }
            catch { return false; }
        }

        private static long GCD(long a, long b)
        {
            while (b != 0) { long t = a % b; a = b; b = t; }
            return a == 0 ? 1 : a;
        }
    }
}