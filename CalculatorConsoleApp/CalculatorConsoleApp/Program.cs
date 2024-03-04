using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputikan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inputkan nilai a = ");
           

            Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));

            Console.WriteLine("Pilih menu calculator");
            Console.WriteLine("\n1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.Write("\nInput Nomor Menu[1,4]: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static float Pembagian(float a, float b)
        {
            return a / b;
        }
    }
}
