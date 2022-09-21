using System;
namespace kalkulator;
class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Title = "Kalkulator Sederhana";

        //header
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("=== SELAMAT DATANG DI KALKULATOR SEDERHANA! ===");

        //list operasi matematika
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Berikut list operasi yang tersedia:");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("1. (+) Penjumlahan\n2. (-) Pengurangan\n3. (X) Perkalian\n4. (/) Pembagian");

        //memilih operasi matematika
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Ketik nomor operasi matematika yang ingin kamu gunakan:");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        int operasi = Convert.ToInt32(Console.ReadLine());

        //input bilangan pertama
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Ketik bilangan pertama:");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        int bil1 = Convert.ToInt32(Console.ReadLine());

        //input bilangan kedua
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Ketik bilangan kedua:");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        int bil2 = Convert.ToInt32(Console.ReadLine());

        //menampilkan hasil operasi matematika
        switch (operasi)
        {
            case 1:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hasil penjumlahan dari " + bil1 + " dan " + bil2 + " adalah " + (bil1 + bil2));
                break;
            case 2:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hasil pengurangan dari " + bil1 + " dan " + bil2 + " adalah " + (bil1 - bil2));
                break;
            case 3:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hasil perkalian dari " + bil1 + " dan " + bil2 + " adalah " + (bil1 * bil2));
                break;
            case 4:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hasil pembagian dari " + bil1 + " dan " + bil2 + " adalah " + (bil1 / bil2));
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Operasi yang kamu pilih tidak tersedia!");
                break;
        }

        //user memilih apakah ingin menghitung lagi
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Apakah kamu ingin menghitung lagi? (y/n)");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        string ulang = Console.ReadLine();
        if (ulang == "y")
        {
            Main(args);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Tekan tombol apapun untuk keluar...");
            Console.ReadKey();
        }
    }
}