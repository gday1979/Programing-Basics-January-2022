using System;

namespace _01._Easter_Lunch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double easterBread = double.Parse(Console.ReadLine());
            double eggs=double.Parse(Console.ReadLine());
            double bake=double.Parse(Console.ReadLine());
            double priceBread = easterBread * 3.20;
            double priceEggs = eggs * 4.35;
            double priceBake = bake * 5.40;
            double paintEgg = eggs * 12 * 0.15;
            double sum=priceBread+priceEggs+priceBake+paintEgg;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
