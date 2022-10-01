using System;
using System.Globalization;

namespace _03._Fitness_Card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string typeOfSport = Console.ReadLine();
            double price = 0;
            switch (gender)
            {
                case "m":
                    switch (typeOfSport)
                    {
                        case "Gym":
                            price += 42;
                            break;
                        case "Boxing":
                            price += 41;
                            break;
                        case "Yoga":
                            price += 45;
                            break;
                        case "Zumba":
                            price += 34;
                            break;
                        case "Dances":
                            price += 51;
                            break;
                        case "Pilates":
                            price += 39;
                            break;
                    }
                    break;
                case "f":
                    switch (typeOfSport)
                    {
                        case "Gym":
                            price += 35;
                            break;
                        case "Boxing":
                            price += 37;
                            break;
                        case "Yoga":
                            price += 42;
                            break;
                        case "Zumba":
                            price += 31;
                            break;
                        case "Dances":
                            price += 53;
                            break;
                        case "Pilates":
                            price += 37;
                            break;
                    }
                    break;
            }
            if (age<=19)
            {
                price *= 0.80;
            }
            if (sum>price)
            {
                Console.WriteLine($"You purchased a 1 month pass for {typeOfSport}.");
            }
            
            else if(price>sum)
            {
                double needSum = price - sum;
                Console.WriteLine($"You don't have enough money! You need ${needSum:f2} more.");
            }
        }
    }
}
