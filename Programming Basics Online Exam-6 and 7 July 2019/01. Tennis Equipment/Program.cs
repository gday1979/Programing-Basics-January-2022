using System;

namespace _01._Tennis_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double equiptment = double.Parse(Console.ReadLine());
            double tenisRacket=double.Parse(Console.ReadLine());
            double dunks=double.Parse(Console.ReadLine());
            double priceRacket=equiptment*tenisRacket;
            double priceDunks = equiptment / 6;
            double allDunks = dunks * priceDunks;
            double priceEquiptment = (priceRacket + allDunks) * 0.20;
            double allSum = priceRacket + allDunks + priceEquiptment;
            double nole = allSum / 8;
            double sponsor = nole * 7;
            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(nole)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(sponsor)}");
        }
    }
}
