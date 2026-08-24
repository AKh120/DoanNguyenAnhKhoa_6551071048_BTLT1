using System;

namespace MayTinhDonGian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai bao hai so thuc
            double a, b;

            // Nhap a
            Console.Write("Nhap so thuc a: ");
            a = double.Parse(Console.ReadLine());

            // Nhap b
            Console.Write("Nhap so thuc b: ");
            b = double.Parse(Console.ReadLine());

            // In ket qua
            Console.WriteLine();
            Console.WriteLine("Ket qua cac phep tinh:");

            Console.WriteLine("Cong: " + (a + b));
            Console.WriteLine("Tru: " + (a - b));
            Console.WriteLine("Nhan: " + (a * b));

            // Kiem tra b khac 0 truoc khi chia
            if (b != 0)
            {
                Console.WriteLine("Chia: " + (a / b));
                Console.WriteLine("Chia lay phan nguyen: " + ((int)a / (int)b));
                Console.WriteLine("Chia lay phan du: " + ((int)a % (int)b));
            }
            else
            {
                Console.WriteLine("Chia: Khong the chia cho 0");
                Console.WriteLine("Chia lay phan nguyen: Khong the chia cho 0");
                Console.WriteLine("Chia lay phan du: Khong the chia cho 0");
            }

            Console.WriteLine("Luy thua a^b: " + Math.Pow(a, b));
        }
    }
}