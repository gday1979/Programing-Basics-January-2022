using System;

namespace _01._Fruit_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceStrawberry = double.Parse(Console.ReadLine());
            double quantityBanana = double.Parse(Console.ReadLine());
            double quantityOrange = double.Parse(Console.ReadLine());
            double quantityRasberry = double.Parse(Console.ReadLine());
            double quantityStrawberry = double.Parse(Console.ReadLine());

            double priceRasberry = (priceStrawberry / 2);
            double allRasberry = quantityRasberry * priceRasberry;
            double priceOrange = priceRasberry - (priceRasberry * 0.40);
            double sumOrange = quantityOrange * priceOrange;
            double priceBanana = priceRasberry - (priceRasberry * 0.80);
            double sumBanana = quantityBanana * priceBanana;
            priceStrawberry *= quantityStrawberry;
            double allSum = allRasberry + sumBanana + sumOrange + priceStrawberry;

            Console.WriteLine($"{allSum:f2}");
        }
    }
}
