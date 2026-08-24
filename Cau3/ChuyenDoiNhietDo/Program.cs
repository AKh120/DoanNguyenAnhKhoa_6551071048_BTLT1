using System;

namespace ChuyenDoiNhietDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai bao bien
            decimal celsius;
            decimal fahrenheit;
            decimal kelvin;

            // Nhap nhiet do Celsius
            Console.Write("Nhap nhiet do Celsius: ");
            celsius = decimal.Parse(Console.ReadLine());

            // Chuyen doi sang Fahrenheit
            fahrenheit = celsius * 9 / 5 + 32;

            // Chuyen doi sang Kelvin
            kelvin = celsius + 273.15m;

            // In ket qua voi 2 chu so thap phan
            Console.WriteLine();
            Console.WriteLine("Nhiet do Fahrenheit: {0:F2}", fahrenheit);
            Console.WriteLine("Nhiet do Kelvin: {0:F2}", kelvin);
        }
    }
}