using System;

namespace VD_TaoMaytinh
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Nhap so thu nhat ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Main menu");
            Console.WriteLine("1. Cong");
            Console.WriteLine("2. Tru");
            Console.WriteLine("3. Nhan");
            Console.WriteLine("4. Chia");
            do
            {
                Console.WriteLine("Nhap phep tinh ban muon thuc hien");
                string chon = Console.ReadLine();
                switch (chon)
                {
                    case "1":
                        int c = a + b;
                        Console.WriteLine("Ket qua a+b la {0}", c);
                        break;
                    case "2":
                        int t = a + b;
                        Console.WriteLine("Ket qua a-b la {0}", t);
                        break;
                    case "3":
                        int n = a * b;
                        Console.WriteLine("Ket qua a*b la {0}", n);
                        break;
                    case "4":
                        float ch =(float) a / b;
                        Console.WriteLine("Ket qua a/b la {0}", ch);
                        break;
                }
            }
            while (true);
        }
    }
}
