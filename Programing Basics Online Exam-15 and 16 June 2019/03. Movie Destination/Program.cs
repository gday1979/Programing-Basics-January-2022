using System;

namespace _03._Movie_Destination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget=double.Parse(Console.ReadLine());
            string destination=Console.ReadLine();
            string season=Console.ReadLine();
            double days=double.Parse(Console.ReadLine());
            double price = 0;
            switch (season)
            {
                case "Winter":
                    switch (destination)
                    {
                        case "Dubai":
                            price = days * 45000;
                            break;
                        case "Sofia":
                            price = days * 17000;
                            break ;
                        case "London":
                            price = days * 24000;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Summer":
                    switch (destination)
                    {
                        case "Dubai":
                            price = days * 40000;
                            break;
                        case "Sofia":
                            price = days * 12500;
                            break;
                        case "London":
                            price = days * 20250;
                            break;
                        default:
                            break;
                    }
                    break ;
                default:
                    break;
            }
            if (destination=="Dubai")
            {
                price *= 0.70;

            }
            if (destination=="Sofia")
            {
                price *= 1.25;
            }
            if (budget>price)
            {
                double leftOverBudget = budget - price;
                Console.WriteLine($"The budget for the movie is enough! We have {leftOverBudget:f2} leva left!");
            }
            else if (price>budget)
            {
                double needSum = price - budget;
                Console.WriteLine($"The director needs {needSum:f2} leva more!");
            }
            
        }
    }
}
