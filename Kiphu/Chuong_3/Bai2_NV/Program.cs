using System;

namespace Bai2_NV
{
    class Program
    {
        static void Main(string[] args)
        {
            Nhanvien nv1 = new Nhanvien("NV1", "Bach D", 3, 12);

            //Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", nv1.MaNV1, nv1.TenNV1, nv1.Luong1h1, nv1.Sogio, nv1.Tinhluong());
            Console.WriteLine(nv1.ToString());
            Console.Read();
        }
    }
}
