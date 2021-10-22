using System;

namespace B4_PhuongThuc
{
    class Program
    {
        static void Main(string[] args)
        {
            Double diemhocphan;
            String diemchu;
            Console.Write("\n Nhap diem thanh phan :");
            diemhocphan = Double.Parse(Console.ReadLine());
            diemchu = Chuyendiemchu(diemhocphan);
            Console.WriteLine("Diem thanh phan :{0} , Diem chu {1}.", diemhocphan, diemchu);
            Console.ReadLine();
        }
        private static string Chuyendiemchu (double diemhocphan)
        {
            String diemchu;
            if (diemhocphan < 4 && diemhocphan > 0)
                diemchu = "F";
            else if (diemhocphan < 5)
                diemchu = "D";
            else if (diemhocphan < 7)
                diemchu = "C";
            else if (diemhocphan < 8.5)
                diemchu = "A";
            else if (diemhocphan < 10)
                diemchu = "A";
            else
                diemchu = "Diem khong hop le";
            return diemchu;
        }
    }
}
