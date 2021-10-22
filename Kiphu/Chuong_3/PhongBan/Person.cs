using System;
using System.Collections.Generic;
using System.Text;

namespace PhongBan
{
    class Person
    {
        private string _hoten;
        private string _diachi;

        public string Hoten { get => _hoten; set => _hoten = value; }
        public string Diachi { get => _diachi; set => _diachi = value; }
        public Person() { }

        public Person( string hoten , string diachi)
        {
            this.Hoten = hoten;
            this.Diachi = diachi;
        }

        internal object GetInfo()
        {
            throw new NotImplementedException();
        }

        /*public override string ToString()
        {
            return String.Format("{0} \t {1} ", this.Hoten, this.Diachi);
        }
        */
    }
}
