using System;

class Program
{
    static void Main()
    {
        Console.Write("Dikdörtgenler prizmasının uzunluğunu girin: ");
        double uzunluk = double.Parse(Console.ReadLine());
        Console.Write("Dikdörtgenler prizmasının genişliğini girin: ");
        double genislik = double.Parse(Console.ReadLine());
        Console.Write("Dikdörtgenler prizmasının yüksekliğini girin: ");
        double yukseklik = double.Parse(Console.ReadLine());

        double hacim = uzunluk * genislik * yukseklik;
        Console.WriteLine("Dikdörtgenler prizmasının hacmi: " + hacim);
    }
}


