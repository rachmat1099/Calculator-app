using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calculator
    {
        static void Main(string[] args)
        {

            Console.Write("Peogram Calculator: \n");
            Console.WriteLine();

            Console.Write("1. Penjumlahan\n");
            Console.Write("2. Pengurangan\n");
            Console.Write("3. Perkalian\n");
            Console.Write("4. Pembagian\n");

            Console.WriteLine();

            Console.Write("Masukan Pilihan [1-4]: ");
            int x = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            if (x == 1)
            {
                Console.Write("Input nilai a = ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Hasil Penjumlahan " + a + " + " + b + " = " + Penambahan(a, b));
            }

            else if (x == 2)
            {
                Console.Write("Input nilai a = ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Hasil Pengurangan: " + a + " - " + b + " = " + Pengurangan(a, b));
            }

            else if (x == 3)
            {
                Console.Write("Input nilai a = ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Hasil Perkalian: " + a + " * " + b + " = " + Perkalian(a, b));
            }

            else if (x == 4)
            {
                Console.Write("Input nilai a = ");
                Double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Input nilai b = ");
                Double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Hasil Pembagian: " + a + " / " + b + " = " + Pembagian(a, b));
            }

            else
            {
                Console.Write("Maaf, pilihan yang anda pilih tidak tersedia");
            }

            Console.WriteLine();
            Console.WriteLine("\nKetik key untuk keluar");
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

        static Double Pembagian(Double a, Double b)
        {
            return a / b;
        }
    }
}