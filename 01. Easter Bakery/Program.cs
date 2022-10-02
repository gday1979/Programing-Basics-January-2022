using System;

namespace _01._Easter_Bakery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceFlour=double.Parse(Console.ReadLine());
            double quantity=double.Parse(Console.ReadLine());
            double quantitySugar=double.Parse(Console.ReadLine());
            double eggs=double.Parse(Console.ReadLine());
            double packageMaja=double.Parse(Console.ReadLine());
            double priceSugar = priceFlour * 0.75;
            double priceEggs = priceFlour * 1.10;
            double pricePackage = priceSugar * 0.20;
            double sumFlour=priceFlour*quantity;
            double sumSugar=priceSugar*quantitySugar;
            double sumEggs=priceEggs*eggs;
            double sumPackageMaja=pricePackage*packageMaja;
            double total=sumFlour+sumSugar+sumEggs+sumPackageMaja;
            Console.WriteLine($"{total:f2}");
        }
    }
}
