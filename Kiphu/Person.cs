using System;
using System.Collections.Generic;
using System.Text;

namespace Ontap
{
    class Person
    {
        private string _hoTen;
        public string hoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
        private string _diaChi;
        public string diaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        public Person() { }
        public Person(string hT, string dC)
        {
            hoTen = hT;
            diaChi = dC;
        }
        public override string ToString()
        {
            return string.Format("{0,-30} {1,-50}", hoTen, diaChi);
        }
    }
}
