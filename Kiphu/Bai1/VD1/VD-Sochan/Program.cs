using System;

namespace VD_Sochan
{
    class Program
    {
        static void Main(string[] args)
        {
            int so1, xo1;
            Console.Write("Kiem tra so chan ");
            Console.Write("Nhap 1 so : ");
            so1 = Convert.ToInt32(Console.ReadLine());
            xo1 = so1 % 2;
            if (xo1 == 0)
            Console.WriteLine("{0} la so chan.\n", so1);
            else
            Console.WriteLine("{0} khong la so chan.\n", so1);
            Console.ReadLine();
        }
    }
}
