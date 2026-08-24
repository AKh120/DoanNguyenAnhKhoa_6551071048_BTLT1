using System;

namespace BangCuuChuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            // Yeu cau nhap lai neu n khong nam trong khoang 1 - 9
            do
            {
                Console.Write("Nhap so nguyen n (1 <= n <= 9): ");
                n = int.Parse(Console.ReadLine());

                if (n < 1 || n > 9)
                {
                    Console.WriteLine("So n khong hop le! Vui long nhap lai.");
                }

            } while (n < 1 || n > 9);

            // In bang cuu chuong
            Console.WriteLine();
            Console.WriteLine("Bang cuu chuong " + n + ":");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
            }
        }
    }
}