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
        Console.WriteLine("=== SELAMAT MENGGUNAKAN KALKULATOR SEDERHANA! ===");

        //list operasi matematika
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Berikut list operasi yang tersedia:");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("1. (+) Penjumlahan\n2. (-) Pengurangan\n3. (*) Perkalian\n4. (/) Pembagian");

        //memilih operasi matematika
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Ketik nomor operasi matematika yang ingin kamu gunakan:");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        int operasi = Convert.ToInt32(Console.ReadLine());

        //deklarasi variabel bilangan 1 dan 2
        float bil1, bil2 = 0.0f;

        //inisialiasi bilangan 1 dan 2
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Ketik bilangan pertama:");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        bil1 = float.Parse(Console.ReadLine() ?? "");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Ketik bilangan kedua:");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        bil2 = float.Parse(Console.ReadLine() ?? "");

        //menampilkan hasil operasi matematika
        switch (operasi)
        {
            case 1:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hasil penjumlahan dari " + bil1 + " dan " + bil2 + " adalah " + (bil1 + bil2) + "\n");
                break;
            case 2:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hasil pengurangan dari " + bil1 + " dan " + bil2 + " adalah " + (bil1 - bil2) + "\n");
                break;
            case 3:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hasil perkalian dari " + bil1 + " dan " + bil2 + " adalah " + (bil1 * bil2) + "\n");
                break;
            case 4:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hasil pembagian dari " + bil1 + " dan " + bil2 + " adalah " + (bil1 / bil2) + "\n");
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Operasi yang kamu pilih tidak tersedia!\n");
                break;
        }

        //user memilih apakah ingin menghitung ulang
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Apakah kamu ingin menghitung lagi? (y/n)");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        string ulang = Console.ReadLine() ?? "";
        if (ulang == "y")
        {
            Main(args);
        }
        else
        {
            //program keluar
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Terima kasih telah mencoba kalkulator sederhana!\nTekan tombol apapun untuk keluar...");
            Console.ReadKey();
        }
    }
}