using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2_NV
{
    class Nhanvien
    {
        private String MaNV;
        private String TenNV;
        private int Luong1h;
        private double sogio;

        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string TenNV1 { get => TenNV; set => TenNV = value; }
        public int Luong1h1 { get => Luong1h; set => Luong1h = value; }
        public double Sogio { get => sogio; set => sogio = value; }

        public Nhanvien(string MaNV, String TenNV, int Luong1h, double sogio)
        {
            this.MaNV = MaNV;
            this.TenNV = TenNV;
            this.Luong1h = Luong1h;
            this.sogio = sogio;
        }
        public Nhanvien() { }

        public double Tinhluong()
        {
            return this.Luong1h1 * this.sogio;
        }
       

        public override string ToString()
        {
            return string.Format("\n {0,-15}{1,-15}{2,-15}{3,-15}{4,-15}", this.MaNV, this.TenNV, this.Luong1h, this.sogio, this.Tinhluong());
        }
    }
}
