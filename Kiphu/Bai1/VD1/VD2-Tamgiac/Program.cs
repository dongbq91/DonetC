using System;

namespace VD2_Tamgiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b, c , S ,CV;
            Console.Write("Nhap canh a :");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhap canh b :");
            b = double.Parse(Console.ReadLine());
            Console.Write("Nhap canh c :");
            c = double.Parse(Console.ReadLine());

            CV = a + b + c;
            S = (a * b) / 2;
            Console.WriteLine("\n Chu vi tam gia la : {0}+{1}+{2}={3}", a.ToString(), b.ToString(), c.ToString(), CV.ToString());
            Console.WriteLine("\n Dien tich tam giac vuong : ({0} * {1})/2 = {2}", a.ToString(), b.ToString(), S.ToString());
            Console.ReadLine();
        }
    }
}
