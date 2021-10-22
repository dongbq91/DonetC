using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1
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

        public void NHapNhanvien(string MaNV , String TenNV, int Luong1h, double sogio) {
            this.MaNV = MaNV;
            this.TenNV = TenNV;
            this.Luong1h = Luong1h;
            this.sogio = sogio;
        }
        public void NHapNhanvien() { }

        public virtual double Tinhluong()
        {
            return this.Luong1h1 * this.sogio;
        }
        public double Tinhluong(int Luong1h , double sogio)
        {
            return Luong1h * sogio;
        }

        public string Xuat()
        {
            return string.Format("\n {0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", this.MaNV, this.TenNV, this.Luong1h, this.sogio, this.Tinhluong());
        }

    }
}
