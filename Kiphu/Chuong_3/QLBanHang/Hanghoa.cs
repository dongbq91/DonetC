using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang
{
    class Hanghoa
    {
        String _maHang;
        String _tenHang;
        double _gia;
        double _soLuong;

        public string MaHang { get => _maHang; set => _maHang = value; }
        public string TenHang { get => _tenHang; set => _tenHang = value; }
        public double Gia { get => _gia; set => _gia = value; }
        public double SoLuong { get => _soLuong; set => _soLuong = value; }

        public Hanghoa(string maHang, string tenHang, double gia, double soLuong)
        {
            _maHang = maHang;
            _tenHang = tenHang;
            _gia = gia;
            _soLuong = soLuong;
        }

        public Hanghoa()
        {
        }
        public double tongTien()
        {
            return SoLuong * Gia;
        }
        public override string ToString()
        {
            return string.Format("{0,-15} {1,-20} {2,-10} {3,-15} {3,-20}", MaHang, TenHang, SoLuong, Gia, tongTien());
        }
    }
}
