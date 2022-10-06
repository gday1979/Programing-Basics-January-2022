using System;

namespace _03._Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vineyard=int.Parse(Console.ReadLine());
            double grapeFor=double.Parse(Console.ReadLine());
            double neededWines=double.Parse(Console.ReadLine());
            int workers=int.Parse(Console.ReadLine());
            double totalWine = vineyard * grapeFor;
            double wine = (totalWine * 0.40) / 2.50;
            double moreWines = wine - neededWines;
            double perPeople = moreWines / workers;
            if (wine<neededWines)
            {
                double tottalSum = neededWines - wine;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(tottalSum)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(moreWines)} liters left -> {Math.Ceiling(perPeople)} liters per person.");
            }
        }
    }
}
