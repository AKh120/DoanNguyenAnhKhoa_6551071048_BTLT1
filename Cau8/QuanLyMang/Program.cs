using System;

namespace QuanLyMang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai bao mang 10 phan tu
            int[] mang = new int[10];

            // Nhap gia tri cho mang
            Console.WriteLine("Nhap 10 phan tu:");

            for (int i = 0; i < mang.Length; i++)
            {
                Console.Write("mang[" + i + "] = ");
                mang[i] = int.Parse(Console.ReadLine());
            }

            // In toan bo mang bang foreach
            Console.WriteLine();
            Console.Write("Toan bo mang: ");

            foreach (int x in mang)
            {
                Console.Write(x + " ");
            }

            // Tinh tong
            int tong = 0;

            foreach (int x in mang)
            {
                tong += x;
            }

            // Tinh trung binh
            double trungBinh = (double)tong / mang.Length;

            Console.WriteLine();
            Console.WriteLine("Tong cac phan tu: " + tong);
            Console.WriteLine("Trung binh cac phan tu: " + trungBinh);

            // Tim gia tri lon nhat va vi tri
            int max = mang[0];
            int viTriMax = 0;

            for (int i = 1; i < mang.Length; i++)
            {
                if (mang[i] > max)
                {
                    max = mang[i];
                    viTriMax = i;
                }
            }

            // Tim gia tri nho nhat va vi tri
            int min = mang[0];
            int viTriMin = 0;

            for (int i = 1; i < mang.Length; i++)
            {
                if (mang[i] < min)
                {
                    min = mang[i];
                    viTriMin = i;
                }
            }

            Console.WriteLine("Gia tri lon nhat: " + max + ", vi tri: " + viTriMax);
            Console.WriteLine("Gia tri nho nhat: " + min + ", vi tri: " + viTriMin);

            // Dem so chan va so le
            int soChan = 0;
            int soLe = 0;

            foreach (int x in mang)
            {
                if (x % 2 == 0)
                {
                    soChan++;
                }
                else
                {
                    soLe++;
                }
            }

            Console.WriteLine("So luong phan tu chan: " + soChan);
            Console.WriteLine("So luong phan tu le: " + soLe);

            // Dao nguoc mang
            Console.Write("Mang sau khi dao nguoc: ");

            for (int i = mang.Length - 1; i >= 0; i--)
            {
                Console.Write(mang[i] + " ");
            }

            Console.WriteLine();
        }
    }
}