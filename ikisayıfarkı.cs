using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = int.Parse(Console.ReadLine());
        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = int.Parse(Console.ReadLine());

        int fark = sayi1 - sayi2;
        Console.WriteLine("İki sayının farkı: " + fark);
    }
}
