using System;

class Program
{
    static void Main()
    {
        int toplam = 0;
        int carpim = 1;

        for (int i = 1; i <= 4; i++)
        {
            Console.Write(i + ". sayıyı girin: ");
            int sayi = int.Parse(Console.ReadLine());
            toplam += sayi;
            carpim *= sayi;
        }

        Console.WriteLine("Toplam: " + toplam);
        Console.WriteLine("Çarpım: " + carpim);
    }
}
