using System;

namespace VD1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Hello World!");
            Console.Write("Hi");
            //Console.ReadLine();
            Console.Write("A=");
            a = int.Parse(Console.ReadLine());
            Console.Write("B=");
            b = int.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Tong{0}+{1}={2} ", a.ToString(), b.ToString(), c.ToString());
            
            Console.ReadLine();
            String name = "Bach Quoc Dong";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Hello world");
            Console.ReadLine();


        }
    }
}
