using System;
using System.Text;
namespace B3_Lap_TienLai
{
    class Program
    {
        static void Main(string[] args)
        {
            Double tienhangthang, laisuatthang, tienthucuoithang;
            int sothang;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập số tiền tiết kiệm hàng tháng : ");
            tienhangthang = double.Parse(Console.ReadLine());
            Console.WriteLine(" Nhập % lại xuất hàng tháng : ");
            laisuatthang = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tháng gửi tiết kiệm");
            sothang = int.Parse(Console.ReadLine());

            tienthucuoithang = 0;
            Console.WriteLine("Tien cuoi thang");
            Console.WriteLine("**** For *****");

            for(int i= 1; i<= sothang; i++)
            {
                tienthucuoithang = (tienhangthang + tienthucuoithang) * (1 + laisuatthang);
                Console.WriteLine("\n {0} , {1}", i, tienthucuoithang.ToString("N2"));
            }
            int thangtinh = 1;
            tienthucuoithang = 0;
            Console.WriteLine("\n*** While ***");
            while (thangtinh <= sothang)
            {
                tienthucuoithang = (tienhangthang + tienthucuoithang) * (1 + laisuatthang);
                Console.WriteLine("\n {0}, {1}", thangtinh, tienthucuoithang.ToString("N2"));
                thangtinh++;
            }
            Console.ReadLine();

        }
    }
}

     