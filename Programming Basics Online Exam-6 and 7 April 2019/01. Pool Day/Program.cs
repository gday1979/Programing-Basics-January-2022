using System;

namespace _01._Pool_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double people=double.Parse(Console.ReadLine());
            double priceEnter=double.Parse(Console.ReadLine());
            double priceSunLoger=double.Parse(Console.ReadLine());  
            double priceUmbrela=double.Parse(Console.ReadLine());
            double sumPrice = people * priceEnter;
            double logger = Math.Ceiling(people * 0.75);
            double sunLoger = logger * priceSunLoger;
            double needUmberla = Math.Ceiling(people * 0.50);
            double umbrella = needUmberla*priceUmbrela;
            double sum=sumPrice +sunLoger+umbrella;
            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
