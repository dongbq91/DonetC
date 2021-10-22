using System;
using System.Collections.Generic;
using System.Text;

namespace PhongBan
{
    class Nhanvien : Person
    {
        string _maNhanVien;
        string _chucVu;
        double _luong;
        

        public string MaNhanVien { get => _maNhanVien; set => _maNhanVien = value; }
        public string ChucVu { get => _chucVu; set => _chucVu = value; }
        public double Luong { get => _luong; set => _luong = value; }
        

        public Nhanvien() { }

        public Nhanvien( string manhanvien ,string hoten , string diachi, string chucvu, double luong ):base(hoten , diachi) 
        {
            this.MaNhanVien = manhanvien;
            this.ChucVu = chucvu;
            this.Luong = luong;
        }
        public double heso(string cv)
        {
            string x = cv.ToLower();
            if (x == "giamdoc") return 10;
            else if (x == "truongphong" || x == "pho giam doc") return 6;
            else if (x == "pho phong") return 4;
            else return 2;
        }

        public override string ToString()
        {
            return string.Format("{0} \t {1} \t {2} \t {3} \t {4} \t {5}", this.MaNhanVien,this.Hoten, this.Diachi, this.ChucVu, this.Luong , heso(ChucVu));
        }

    }
}
