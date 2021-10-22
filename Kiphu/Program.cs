using System;
using System.Collections.Generic;

namespace Ontap
{
    class Program
    {
        static private List<NhanVien> dsNV = new List<NhanVien>();
        static void Main(string[] args)
        {
            //a)
            do
            {
                Console.Clear();
                Console.WriteLine("============Main Menu============");
                Console.WriteLine("1. Them nhan vien moi.");
                Console.WriteLine("2. Hien thi danh sach nhan vien.");
                Console.WriteLine("3. Sap xep danh sach.");
                Console.WriteLine("4. Thoat.");
                Console.Write("- Chon: ");
                string chon = Console.ReadLine();

                switch(chon)
                {
                    case "1":
                        Console.Clear();
                        themNV();
                        break;
                    case "2":
                        Console.Clear();
                        xuatDSNV();
                        Console.WriteLine("\nEnter de tiep tuc!");
                        Console.ReadLine();
                        break;
                    case "3":
                        sapXep();
                        Console.WriteLine("\nEnter de tiep tuc!");
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Tam biet!");
                        Console.ResetColor();
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Lua chon sai.\nEnter de tiep tuc!");
                        Console.ReadLine();
                        Console.ResetColor();
                        break;
                }
            }
            while (true);
        }

        //b)
        static private void themNV()
        {
            string ma, ten, dc, cv;
            double lcb;
            Console.Write("Nhap ma nhan vien: ");
            ma = Console.ReadLine();

            foreach (NhanVien i in dsNV)
                if (i.maNV == ma)
                { 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ma nhan vien da ton tai. Nhap ket thuc.\nEnter de tiep tuc!");
                    Console.ReadLine();
                    Console.ResetColor();
                    return; 
                }

            Console.Write("Nhap ho ten nhan vien: ");
            ten = Console.ReadLine();
            Console.Write("Nhap dia chi nhan vien: ");
            dc = Console.ReadLine();
            Console.Write("Nhap chuc vu nhan vien: ");
            cv = Console.ReadLine();
            Console.Write("Nhap luong co ban nhan vien: ");
            lcb = double.Parse(Console.ReadLine());

            NhanVien newNV = new NhanVien(ten, dc, ma, cv, lcb);
            dsNV.Add(newNV);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Them moi thanh cong.\nEnter de tiep tuc!");
            Console.ReadLine();
            Console.ResetColor();
        }
        //c)
        static private void xuatDSNV()
        {
            Console.WriteLine("{0, -15} {1, -30} {2, -30} {3, -15} {4, -15} {5, -10}", "Ma NV", "Ho ten", "Dia chi", "Chuc vu", "Luong co ban", "He so CV");
            foreach (NhanVien i in dsNV)
                Console.WriteLine(i.ToString());
        }
        //d)
        static private void sapXep()
        {
            Console.Clear();
            for (int i = 0; i < dsNV.Count - 1; i++)
                for (int j = dsNV.Count - 1; j > i; j--)
                    if(dsNV[j].luongCoBan < dsNV[j-1].luongCoBan)
                    {
                        NhanVien tg = dsNV[j];
                        dsNV[j] = dsNV[j - 1];
                        dsNV[j - 1] = tg;
                    }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Danh sach nhan vien sau khi sap xep la:");
            Console.ResetColor();
            xuatDSNV();
        }
    }
}
