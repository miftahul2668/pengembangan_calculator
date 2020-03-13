using System;

namespace CaclulatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi kalkulator";

            Console.WriteLine("=====================");
            Console.WriteLine("Pilih Menu Kalkulator");
            Console.WriteLine("=====================");
            Console.WriteLine("1.Penambahan");
            Console.WriteLine("2.Pengurangan");
            Console.WriteLine("3.Perkalian");
            Console.WriteLine("4.Pembagian");
            Console.WriteLine("=====================");
            Console.WriteLine("\nInputkan Nomor Menu [1...4] : ");
            int x = int.Parse(Console.ReadLine());
           

            if (x == 1)
            {
                Console.WriteLine("Inputkan Nilai Pertama : ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan Nilai Kedua : ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Penambahan" + a + "+" + b + "=" + penambahan(a, b));
                Console.WriteLine("\ntekan sembarang Untuk Keluar");
                Console.ReadKey();
            }
            else if (x == 2)
            {
                Console.WriteLine("Inputkan Nilai Pertama : ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan Nilai Kedua : ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pengurangan" + a + "-" + b + "=" + pengurangan(a, b));
                Console.WriteLine("\ntekan sembarang Untuk Keluar");
                Console.ReadKey();
            }
            else if (x == 3)
            {
                Console.WriteLine("Inputkan Nilai Pertama : ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan Nilai Kedua : ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Perkalian" + a + "*" + b + "=" + perkalian(a, b));
                Console.WriteLine("\ntekan sembarang Untuk Keluar");
                Console.ReadKey();
            }
            else if (x == 4)
            {
                Console.WriteLine("Inputkan Nilai Pertama : ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan Nilai Kedua : ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pembagian" + a + "/" + b + "=" + pembagian(a, b));
                Console.WriteLine("\ntekan sembarang Untuk Keluar");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Inputan Salah ");
                Console.WriteLine("ntekan sembarang Untuk Keluar");
                Console.ReadKey();


            }
            int penambahan(int a, int b)
            {
                return a + b;

            }
            int pengurangan(int a, int b)
            {
                return a - b;

            }
            int perkalian(int a, int b)
            {
                return a * b;

            }
            int pembagian(int a, int b)
            {
                return a / b;

            }
        }
    }
}