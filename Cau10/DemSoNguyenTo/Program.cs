using System;

namespace DemSoNguyenTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Nhap so nguyen duong n
                Console.Write("Nhap so nguyen duong n (n <= 1000): ");
                int n = int.Parse(Console.ReadLine());

                // Kiem tra n hop le
                if (n <= 0 || n > 1000)
                {
                    Console.WriteLine("n phai la so nguyen duong va n <= 1000!");
                    return;
                }

                int soLuong = 0;

                Console.WriteLine();
                Console.WriteLine("Cac so nguyen to tu 2 den " + n + ":");

                // Duyet cac so tu 2 den n
                for (int i = 2; i <= n; i++)
                {
                    bool laSoNguyenTo = true;

                    // Kiem tra i co phai la so nguyen to khong
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            laSoNguyenTo = false;
                            break;
                        }
                    }

                    // Neu la so nguyen to thi in ra
                    if (laSoNguyenTo)
                    {
                        Console.Write(i + " ");
                        soLuong++;
                    }
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Tong so luong so nguyen to: " + soLuong);
            }
            catch (FormatException)
            {
                Console.WriteLine("Loi: Vui long nhap mot so nguyen!");
            }
        }
    }
}