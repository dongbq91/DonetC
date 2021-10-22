using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_CaseNV
{
    class Program
    {
        static private List<Nhanvien> dsNhanvien = new List<Nhanvien>();
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\n Main Menu");
                Console.WriteLine("\n 1. Nhap NV moi");
                Console.WriteLine("\n 2. Hien thi danh sach");
                Console.WriteLine("\n 3. Tinh luong TB");
                Console.WriteLine("\n 4.Thoat");

                string chon = Console.ReadLine();
                switch (chon)
                {
                    case "1":
                        Program.NhapKHmoi();
                        break;
                    case "2":
                        Console.WriteLine("\n{0,-15}{1,-20}{2,-15}{3,-18}{4,-15}{5,-20}", "MaVN", "Ten VN", "Luong 1 h ", " So gio lam viec", "He so phu cap", " Tien Luong");
                        xuatdsNV();
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("\n Luong trin binh = {0}", TinhluongTB());
                        Console.ReadLine();
                        break;
                    case "4":
                        return;
                        Console.WriteLine("Bye ban");
                        Console.ReadLine();
                        break;
                }
                
            } while (true);
        }
        static private void NhapKHmoi()
        {
            string MaNV, TenNV;
            int luong1h;
            double sogio, hesophucap;
            Console.WriteLine("\n 1. Nhan vien");
            Console.WriteLine("\n 2. Quan ly");
            Console.WriteLine("\n Nhap lua cho cua ban");
            string chonnv = Console.ReadLine();
            switch (chonnv)
            {
                case "1":
                    Console.Write("\nNhap ma nhan vien: ");
                    MaNV = Console.ReadLine();
                    Console.Write("\nNhap ten nhan vien: ");
                    TenNV = Console.ReadLine();
                    Console.Write("\nNhap luong 1 gio: ");
                    luong1h = int.Parse(Console.ReadLine());
                    Console.Write("\nNhap so gio lam viec: ");
                    sogio = int.Parse(Console.ReadLine());
                    Nhanvien nhanVienMoi = new Nhanvien(MaNV, TenNV , luong1h , sogio);
                    dsNhanvien.Add(nhanVienMoi);
                    break;
                case "2":
                    Console.Write("\nNhap ma quan ly: ");
                    MaNV = Console.ReadLine();
                    Console.Write("\nNhap ten quan ly: ");
                    TenNV = Console.ReadLine();
                    Console.Write("\nNhap luong 1 gio: ");
                    luong1h = int.Parse(Console.ReadLine());
                    Console.Write("\nNhap so gio lam viec: ");
                    sogio = int.Parse(Console.ReadLine());
                    Console.Write("\nNhap he so phu cap: ");
                    hesophucap = int.Parse(Console.ReadLine());
                    QlNhanvien qlNhanvienmoi = new QlNhanvien(MaNV, TenNV, luong1h, sogio, hesophucap);
                    dsNhanvien.Add(qlNhanvienmoi);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nBan da nhap sai lua chon. Nhan Enter de tiep tuc!");
                    Console.ReadLine();
                    Console.ResetColor();
                    break;

            }
            Console.ReadLine();
        }
        static private void xuatdsNV()
        {
            foreach (Nhanvien item in dsNhanvien)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static private double TinhluongTB()
        {
            double tong = 0;
            foreach (Nhanvien item in dsNhanvien)
            {
                tong += item.Tinhluong(); 
            }
            return tong / dsNhanvien.Count;
        }
    }
}
