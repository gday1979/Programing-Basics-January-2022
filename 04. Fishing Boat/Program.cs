using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season=Console.ReadLine();
            int fishMan=int.Parse(Console.ReadLine());
            double springPrice = 3000;
            double summerAndAutmnPrice = 4200;
            double winterPrice = 2600;
            double total=0.0;
            switch (season)
            {
                case "Spring":
                    if (fishMan <= 6)
                    {
                        total = springPrice * 0.90;
                    }
                    else if (fishMan > 7 && fishMan <= 11)
                    {
                        total = springPrice * 0.85;
                    }
                    else if (fishMan > 12)
                    {
                        total = springPrice * 0.75;
                    }
                    break;
                case "Summer":
                case "Autumn":
                    if (fishMan <= 6)
                    {
                        total = summerAndAutmnPrice * 0.90;
                    }
                    else if (fishMan > 7 && fishMan <= 11)
                    {
                        total = summerAndAutmnPrice * 0.85;
                    }
                    else if (fishMan > 12)
                    {
                        total = summerAndAutmnPrice * 0.75;
                    }
                    break;
                case "Winter":
                    if (fishMan <= 6)
                    {
                        total = winterPrice * 0.90;
                    }
                    else if (fishMan > 7 && fishMan <= 11)
                    {
                        total = winterPrice * 0.85;
                    }
                    else if (fishMan > 12)
                    {
                        total = winterPrice * 0.75;
                    }
                    break;
                default:
                    break;
            }
                    double discount = 0;
                    if (fishMan %2==0 && season !="Autumn")
                    {
                        discount = 0.05;
                    }
                    double totalSum = budget - (total - total * discount);
                    if (totalSum>=0)
                    {
                        Console.WriteLine($"Yes! You have {totalSum:f2} leva left.");
                    }
                    else
                    {
                Console.WriteLine($"Not enough money! You need {(totalSum*-1):f2} leva.");
                    }
            

        }
    }
}
