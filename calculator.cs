using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("Pilih menu calculator : ");
            Console.WriteLine("1. Pertambahan ");
            Console.WriteLine("2. Pengurangan ");
            Console.WriteLine("3. Perkalian ");
            Console.WriteLine("4. Pembagian");
            Console.Write("Input nomor menu [1..4] : ");
            int pilihan =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Masukkan angka a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan angka b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (pilihan == 1)
            {
                Console.WriteLine("Hasil pertambahan {0} + {1} = {2}",a,b, pertambahan(a,b));
            } 
            else if (pilihan == 2)
            {
                Console.WriteLine("Hasil pengurangan {0} - {1} = {2}",a,b, pengurangan(a,b));
            }
            else if (pilihan == 3)
            {
                Console.WriteLine("Hasil perkalian {0} * {1} = {2}",a,b, perkalian(a,b));
            }
            else if(pilihan == 4)
            {
                Console.WriteLine("Hasil pembagian {0} / {1} = {2}",a,b, pembagian(a,b));
            }
            else
            {
                Console.WriteLine("Maaf, inputan tidak sesuai dengan pilihan");
            }
            Console.WriteLine();
            Console.WriteLine("Tekan sembarang key untuk keluar");
            Console.ReadKey();



            static int pertambahan ( int a, int b)
            {
                return a + b ;
            }
            static int pengurangan ( int a, int b)
            {
                return a - b ;
            }
            static int perkalian ( int a, int b)
            {
                return a * b ;
            }
            static int pembagian ( int a, int b)
            {
                return a / b ;
            }
        }
    }
}