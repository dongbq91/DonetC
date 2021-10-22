using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongBan
{
    class Program
    {
        static private List<Nhanvien> dsnhanvien = new List<Nhanvien>();
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\n Main Menu");
                Console.WriteLine("\n 1. Nhap NV moi");
                Console.WriteLine("\n 2. Hien thi danh sach");
                Console.WriteLine("\n 3. Sap xep");
                Console.WriteLine("\n 4.Thoat");

                string chon = Console.ReadLine();

                switch (chon)
                {
                    case "1":
                        Console.WriteLine("Nhap");
                        NhapNV();
                        break;
                    case "2":
                        Console.WriteLine("\n{0}\t {1}\t {2}\t {3}\t {4}", " Ma NV ", "Ten NV", " Dia chi", "Chuc vu", "Luong co ban");
                        xuatdsNV();
                        break;
                    case "3":
                        Console.WriteLine("\n {0}\t {1}\t {2}\t {3}\t {4}", " Ma NV ", "Ten NV", " Dia chi", "Chuc vu", "Luong co ban");
                        sapxepNV();
                        break;
                    case "4":
                        return;
                        Console.WriteLine("Bye ban");
                        Console.ReadLine();
                        break;
                }
            }
            while (true);
        }
        static void NhapNV()
        {
            string manhanvien, hoten, diachi, chucvu;
            double luong;

            Console.Write("\nNhap ma nhan vien: ");
            manhanvien = Console.ReadLine();
            Console.Write("\nNhap ten nhan vien: ");
            hoten = Console.ReadLine();
            Console.Write("\nNhap dia chi: ");
            diachi = Console.ReadLine();
            Console.Write("\nNhap chuc vu: ");
            chucvu = Console.ReadLine();
            Console.Write("\nNhap luong: ");
            luong = Convert.ToDouble( Console.ReadLine());

            Nhanvien nhanvienmoi = new Nhanvien(manhanvien,hoten,diachi, chucvu, luong);
            dsnhanvien.Add(nhanvienmoi);

        }
        static private void xuatdsNV()
        {
            Console.WriteLine("{0, -15} {1, -30} {2, -30} {3, -15} {4, -15} {5, -10}", "Ma NV", "Ho ten", "Dia chi", "Chuc vu", "Luong co ban", "He so CV");
            foreach (Nhanvien item in dsnhanvien)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static private void sapxepNV()
        {
            Console.Clear();
            for (int i = 0; i < dsnhanvien.Count - 1; i++)
                for (int j = dsnhanvien.Count - 1; j > i; j--)
                    if (dsnhanvien[j].Luong < dsnhanvien[j - 1].Luong)
                    {
                        Nhanvien tg = dsnhanvien[j];
                        dsnhanvien[j] = dsnhanvien[j - 1];
                        dsnhanvien[j - 1] = tg;
                    }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Danh sach nhan vien sau khi sap xep la:");
            xuatdsNV();
        }
    }
}
