using System;
using System.Collections.Generic;
using System.IO;

namespace BachQuocDong_2018604425_KT
{
    class Program
    {
        static private List<Nhanvien> DSNhanvien = new List<Nhanvien>();
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("============Main Menu============");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1. Nhap Nhan vien .");
                Console.WriteLine("2. Hien thi danh Nhan vien ");
                Console.WriteLine("3. Sua nhan vien");
                Console.WriteLine("4. Xoa Nhan vien.");
                Console.WriteLine("5. Thoat.");

                Console.Write("- Chon: ");
                string chon = Console.ReadLine();
                Console.ResetColor();

                switch (chon)
                {
                    case "1":
                        Console.WriteLine("Nhap nhan vien");
                        themnv();
                        break;
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Xuat nhan vien");
                        xuatnv();

                        Console.ReadLine();
                        break;
                    case "3":
                        suanv();
                        Console.ReadLine();
                        break;
                    case "4":
                        xoanv();
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Tam biet!");
                        Console.ResetColor();
                        return;
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
        static private void themnv()
        {
            Console.Clear();
            string tennv;
            int luong1gio;
            double sogio;
            Console.Write("Nhap ten nhan vien: ");
            tennv = Console.ReadLine();
            Console.Write("Nhap so luong 1 gio: ");
            luong1gio = int.Parse(Console.ReadLine());
            Console.Write("Nhap so gio : ");
            sogio = double.Parse(Console.ReadLine());

            Nhanvien newnv = new Nhanvien(tennv, luong1gio, sogio);
            DSNhanvien.Add(newnv);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Them thanh cong!\nEnter de tiep tuc!");
            Console.ResetColor();
        }
        static private void xuatnv()
        {
            Console.Clear();
            Console.WriteLine("{0,-15} {1,-20} {2,-10} {3,-15}", "Ten Nhan vien", "Luong 1 gio", "So gio", "Tinh luong");
            foreach (Nhanvien i in DSNhanvien)
                Console.WriteLine(i.ToString());
            Console.WriteLine("\nEnter de tiep tuc!");
        }
        static private void xoanv()
        {
            Console.Clear();
            Console.Write("Nhap ten nhan vien can xoa: ");
            string ten = Console.ReadLine();
            int i;
            for (i = 0; i < DSNhanvien.Count; i++)
                if (DSNhanvien[i].TenNV1 == ten)
                    break;
            DSNhanvien.RemoveAt(i);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Xoa thanh cong!");
            Console.ResetColor();
            Console.ReadLine();

            Console.WriteLine("\nDanh sach hang sau khi xoa la:");
            xuatnv();
        }
        static private void suanv()
        {
            string tennv;
            int luong1gio;
            double sogio;
            Console.Clear();
            Console.Write("Nhap ten nhan vien can sua :");
            string ten = Console.ReadLine();
            Nhanvien found = DSNhanvien.Find(
                (Nhanvien ob) => { return (ob.TenNV1.Equals(ten)); }
            );
            if (found != null)
            {
                Console.Write("Sua ten nhan vien: ");
                tennv = Console.ReadLine();
                Console.Write("Sua so luong 1 gio: ");
                luong1gio = int.Parse(Console.ReadLine());
                Console.Write("Sua so gio : ");
                sogio = double.Parse(Console.ReadLine());

                found.TenNV1 = tennv;
                found.Luong1h1 = luong1gio;
                found.Sogio = sogio;
            }
            else
            {
                Console.WriteLine("Khong co");

            }

        }
    }   
}
