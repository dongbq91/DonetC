using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3_CaseNV
{
    class QlNhanvien : Nhanvien
    {
        private double _hesophucap;

        public QlNhanvien(string MaNV, string TenNV, int Luong1h, double sogio, double hesophucap) : base(MaNV, TenNV, Luong1h, sogio)
        {
        }

        public double Hesophucap { get => _hesophucap; set => _hesophucap = value; }

        public override double Tinhluong()
        {
            return this.Luong1h1 * this.Sogio * (1 + this.Hesophucap);
        }
        public override string ToString()
        {
            return string.Format("\n {0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{4,-15}", this.MaNV1, this.TenNV1, this.Luong1h1, this.Sogio, this.Hesophucap, this.Tinhluong());
        }
    }
}
