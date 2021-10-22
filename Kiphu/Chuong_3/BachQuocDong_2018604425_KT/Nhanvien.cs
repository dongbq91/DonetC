using System;
using System.Collections.Generic;
using System.Text;

namespace BachQuocDong_2018604425_KT
{
    class Nhanvien
    {
        
        private String TenNV;
        private int Luong1h;
        private double sogio;

       
        public string TenNV1 { get => TenNV; set => TenNV = value; }
        public int Luong1h1 { get => Luong1h; set => Luong1h = value; }
        public double Sogio { get => sogio; set => sogio = value; }

        public Nhanvien( String TenNV, int Luong1h, double sogio)
        {
            
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
            return string.Format("\n {0,-15}{1,-15}{2,-15}{3,-15}",this.TenNV, this.Luong1h, this.sogio, this.Tinhluong());
        }
    }
}
