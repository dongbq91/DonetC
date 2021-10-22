using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b, x;
            Console.Write("Nhap a:");
            a = double.Parse(Console.ReadLine());
            Console.Write("\n Nhap b : ");
            b = double.Parse(Console.ReadLine());
            x = -b / a;
            Console.WriteLine("\n Phuong trinh co nghiem {0}x + {1} = 0 co nghiem x= {2}", a.ToString(), b.ToString(), x.ToString());
            Console.ReadLine();
        }
    }
}
