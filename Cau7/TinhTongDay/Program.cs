using System;

namespace TinhTongDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai bao bien
            int n;
            long tong = 0;
            long tongChan = 0;
            long tongLe = 0;
            long giaiThua = 1;

            // Nhap n
            Console.Write("Nhap so nguyen duong n: ");
            n = int.Parse(Console.ReadLine());

            // Kiem tra n
            if (n <= 0)
            {
                Console.WriteLine("n phai la so nguyen duong!");
                return;
            }

            // Dung vong lap for de tinh cac tong
            for (int i = 1; i <= n; i++)
            {
                // Tong 1 + 2 + ... + n
                tong += i;

                // Tong cac so chan
                if (i % 2 == 0)
                {
                    tongChan += i;
                }

                // Tong cac so le
                if (i % 2 != 0)
                {
                    tongLe += i;
                }
            }

            // Dung vong lap while de tinh giai thua
            int j = 1;

            while (j <= n)
            {
                giaiThua *= j;
                j++;
            }

            // In ket qua
            Console.WriteLine();
            Console.WriteLine("Tong 1 + 2 + ... + n = " + tong);
            Console.WriteLine("Tong cac so chan tu 1 den n = " + tongChan);
            Console.WriteLine("Tong cac so le tu 1 den n = " + tongLe);
            Console.WriteLine("Giai thua n! = " + giaiThua);
        }
    }
}