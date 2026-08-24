using System;

namespace XuLyChuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhap chuoi ho ten
            Console.Write("Nhap ho ten day du: ");
            string hoTen = Console.ReadLine();

            // Do dai chuoi
            Console.WriteLine("Do dai chuoi: " + hoTen.Length);

            // Chuoi chu hoa
            Console.WriteLine("Chuoi chu HOA: " + hoTen.ToUpper());

            // Chuoi chu thuong
            Console.WriteLine("Chuoi chu thuong: " + hoTen.ToLower());

            // Xoa khoang trang hai dau
            string chuoiTrim = hoTen.Trim();
            Console.WriteLine("Chuoi sau khi Trim: " + chuoiTrim);

            // Kiem tra co chua tu Nguyen hay khong
            if (hoTen.Contains("Nguyễn"))
            {
                Console.WriteLine("Chuoi co chua tu \"Nguyen\"");
            }
            else
            {
                Console.WriteLine("Chuoi khong chua tu \"Nguyen\"");
            }

            // Tach chuoi thanh tung tu
            string[] danhSachTu = chuoiTrim.Split(' ');

            Console.WriteLine();
            Console.WriteLine("Tung tu trong chuoi:");

            foreach (string tu in danhSachTu)
            {
                if (tu != "")
                {
                    Console.WriteLine(tu);
                }
            }

            // Ghep lai bang dau -
            string chuoiGhep = String.Join("-", danhSachTu);

            Console.WriteLine();
            Console.WriteLine("Chuoi sau khi ghep: " + chuoiGhep);
        }
    }
}