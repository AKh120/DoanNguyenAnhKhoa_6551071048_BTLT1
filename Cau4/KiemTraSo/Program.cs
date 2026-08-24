using System;

namespace KiemTraSo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai bao bien
            int n;

            // Nhap so nguyen
            Console.Write("Nhap mot so nguyen: ");
            n = int.Parse(Console.ReadLine());

            // Kiem tra so duong, am hay bang 0
            if (n > 0)
            {
                Console.WriteLine("So do la so duong");
            }
            else if (n < 0)
            {
                Console.WriteLine("So do la so am");
            }
            else
            {
                Console.WriteLine("So do bang 0");
            }

            // Kiem tra so chan hay le
            if (n % 2 == 0)
            {
                Console.WriteLine("So do la so chan");
            }
            else
            {
                Console.WriteLine("So do la so le");
            }

            // Kiem tra co chia het cho 3 khong
            if (n % 3 == 0)
            {
                Console.WriteLine("So do chia het cho 3");
            }
            else
            {
                Console.WriteLine("So do khong chia het cho 3");
            }

            // Kiem tra co chia het cho ca 2 va 3 khong
            if (n % 2 == 0 && n % 3 == 0)
            {
                Console.WriteLine("So do chia het cho ca 2 va 3");
            }
            else
            {
                Console.WriteLine("So do khong chia het cho ca 2 va 3");
            }
        }
    }
}