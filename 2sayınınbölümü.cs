using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = double.Parse(Console.ReadLine());
        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = double.Parse(Console.ReadLine());

        if (sayi2 != 0)
        {
            double bolum = sayi1 / sayi2;
            Console.WriteLine("İki sayının bölümü: " + bolum);
        }
        else
        {
            Console.WriteLine("Bir sayıyı sıfıra bölemezsiniz.");
        }
    }
}

