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
            double sunLoger = people * 0.75;
            double umbrella = people * 0.50;
            double sum=(people*priceEnter)+(priceSunLoger*sunLoger)+(priceUmbrela*umbrella);
            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
