using System;
using System.Text;
namespace B2_CTrucReNhanh
{
    class Program
    {
        static void Main(string[] args)
        {
            Double diemhocphan;
            String dienchu = null;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhập điểm thành phần : ");
            diemhocphan = double.Parse(Console.ReadLine());
            if (diemhocphan < 4 && diemhocphan > 0)
                dienchu = "F";
            else if (diemhocphan < 5)
                dienchu = "D";
            else if (diemhocphan < 7)
                dienchu = "C";
            else if(diemhocphan < 8.5)
                dienchu = "A";
            else if (diemhocphan < 10)
                dienchu = "A";
            Console.WriteLine("Điểm học phần : {0} , Điểm chữ : {1}", diemhocphan, dienchu);
            Console.ReadLine();
        }
    }
}
