using System;

namespace VD_Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            Console.WriteLine("nhap a");
            a = Console.ReadLine();
            Console.WriteLine("nhap b");
            b = Console.ReadLine();

            string[] manga = a.Split();
            int dem = 0;
            foreach (string i in manga)
                if (i == b) 
                    dem++;
            Console.WriteLine("Co {0} chuoi b trong a :", dem);
            Console.ReadLine();
        }
    }
}
