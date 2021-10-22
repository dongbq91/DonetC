using System;
using System.Collections.Generic;
using System.IO;
namespace QLBanHang
{
    class Program
    {
        static private List<Hanghoa> DSHang = new List<Hanghoa>();
        static void Main(string[] args)
            {
                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("============Main Menu============");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("1. Nhap them hang.");
                    Console.WriteLine("2. Hien thi danh sach hang.");
                    Console.WriteLine("3. Tim kiem  thong tin mat hang.");
                    Console.WriteLine("4. Xoa mat hang.");
                    Console.WriteLine("5. Thoat.");
                    Console.WriteLine("6. Sap xep");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("- Chon: ");
                    string chon = Console.ReadLine();
                    Console.ResetColor();

                    switch (chon)
                    {
                        case "1":
                            themHang();
                        StreamWriter sw = new StreamWriter("Hanghoa.txt", true);
                        foreach (Hanghoa item in DSHang)
                        {
                            sw.WriteLine(item);
                        }
                        sw.Close();
                            Console.ReadLine();
                            break;
                        case "2":
                            xuatDSHang();
                        StreamReader sr = new StreamReader("Hanghoa.txt");
                        while(sr.Peek() != -1)
                        {
                            Console.WriteLine(sr.ReadLine());
                        }
                        sr.Close();
                            Console.ReadLine();
                            break;
                        case "3":
                            timHang();
                            Console.ReadLine();
                            break;
                        case "4":
                            xoaHang();
                            Console.ReadLine();
                            break;
                        case "5":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Tam biet!");
                            Console.ResetColor();
                            return;
                        case "6":
                        Console.WriteLine("Sap xem the luong");
                        sapxep();
                        Console.ReadLine();
                        break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nLua chon sai.\nEnter de tiep tuc!");
                            Console.ResetColor();
                            Console.ReadLine();
                            break;
                    }
                }
                while (true);
            }

            static private void themHang()
            {
                Console.Clear();
                string ma, ten;
                int sl;
                double gia;

                Console.Write("Nhap ma hang: ");
                ma = Console.ReadLine();
                Console.Write("Nhap ten hang: ");
                ten = Console.ReadLine();
                Console.Write("Nhap so luong: ");
                sl = int.Parse(Console.ReadLine());
                Console.Write("Nhap don gia: ");
                gia = double.Parse(Console.ReadLine());

                Hanghoa newHH = new Hanghoa(ma, ten, sl, gia);
                DSHang.Add(newHH);

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Them thanh cong!\nEnter de tiep tuc!");
                Console.ResetColor();
            }

            static private void xuatDSHang()
            {
                Console.Clear();
                Console.WriteLine("{0,-15} {1,-20} {2,-10} {3,-15} {3,-25}", "Ma Hang", "Ten Hang", "So Luong", "Gia", "Tong tien");
                foreach (Hanghoa i in DSHang)
                    Console.WriteLine(i.ToString());
                Console.WriteLine("\nEnter de tiep tuc!");
            }

            static private void timHang()
            {
                Console.Clear();
                Console.Write("Nhap ma hang can tim: ");
                string ma = Console.ReadLine();
                Console.WriteLine("Thong tin hang can tim: ");
                Console.WriteLine("{0,-15} {1,-20} {2,-10} {3,-15} {3,-25}", "Ma Hang", "Ten Hang", "So Luong", "Gia", "Tong tien");
                foreach (Hanghoa i in DSHang)
                    if (i.MaHang == ma)
                        Console.WriteLine(i.ToString());
                Console.WriteLine("\nEnter de tiep tuc!");
            }
            static private void xoaHang()
            {
                Console.Clear();
                Console.Write("Nhap ma hang can xoa: ");
                string ma = Console.ReadLine();

                int i;
                for (i = 0; i < DSHang.Count; i++)
                    if (DSHang[i].MaHang == ma)
                        break;
                DSHang.RemoveAt(i);

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Xoa thanh cong!");
                Console.ResetColor();
                Console.ReadLine();

                Console.WriteLine("\nDanh sach hang sau khi xoa la:");
                xuatDSHang();
            }
            static private void sapxep()
            {
                Console.Clear();
            for (int i = 0; i < DSHang.Count - 1; i++)
                for (int j = DSHang.Count - 1; j > i; j--)
                    if (DSHang[j - 1].Gia < DSHang[j].Gia)
                    {
                        Hanghoa tg = DSHang[j];
                        DSHang[j] = DSHang[j - 1];
                        DSHang[j - 1] = tg;
                    }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Danh sach nhan vien sau khi sap xep la:");
            xuatDSHang();
        }
        }
    
}
