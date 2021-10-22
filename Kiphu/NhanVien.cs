using System;
using System.Collections.Generic;
using System.Text;

namespace Ontap
{
    class NhanVien : Person
    {
        private string _maNV;
        public string maNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }
        private string _chucVu;
        public string chucVu
        {
            get { return _chucVu; }
            set { _chucVu = value; }
        }
        private double _luongCoBan;
        public double luongCoBan
        {
            get { return _luongCoBan; }
            set { _luongCoBan = value; }
        }

        public NhanVien(string hT, string dC, string ma, string cV, double lCB) : base(hT, dC)
        {
            maNV = ma;
            chucVu = cV;
            luongCoBan = lCB;
        }

        public double heSoCV(string cv)
        {
            string x = cv.ToLower();
            if (x == "giam doc") return 10;
            else if (x == "truong phong" || x == "pho giam doc") return 6;
            else if (x == "pho phong") return 4;
            else return 2;
        }
        public override string ToString()
        {
            return string.Format("{0, -15} {1, -30} {2, -30} {3, -15} {4, -15} {5, -10}", maNV, hoTen, diaChi, chucVu, luongCoBan, heSoCV(chucVu));
        }
    }
}
