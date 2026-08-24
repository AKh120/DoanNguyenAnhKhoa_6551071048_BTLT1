using System;

namespace ChaoHoiApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai bao bien
            string hoTen;
            int tuoi;
            double chieuCao;
            float canNang;
            bool daTotNghiep;

            // Nhap du lieu
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap tuoi: ");
            tuoi = int.Parse(Console.ReadLine());

            Console.Write("Nhap chieu cao (m): ");
            chieuCao = double.Parse(Console.ReadLine());

            Console.Write("Nhap can nang (kg): ");
            canNang = float.Parse(Console.ReadLine());

            Console.Write("Da tot nghiep (true/false): ");
            daTotNghiep = bool.Parse(Console.ReadLine());

            // In ket qua
            Console.WriteLine();
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Tuoi: " + tuoi);
            Console.WriteLine("Chieu cao: " + chieuCao + " m");
            Console.WriteLine("Can nang: " + canNang + " kg");
            Console.WriteLine("Da tot nghiep: " + daTotNghiep);
        }
    }
}