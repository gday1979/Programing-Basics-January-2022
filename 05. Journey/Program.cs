using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double budget=double.Parse(Console.ReadLine());
            string season=Console.ReadLine();
            string country = "";
            string type = "";
            double total = 0;
            switch (season)
            {
                case "summer":
                    if (budget<=100)
                    {
                        country = "Bulgaria";
                        total = budget * 0.30;
                        type = "Camp";
                    }
                    else if (budget<=1000)
                    {
                        country = "Balkans";
                        total = budget * 0.40;
                        type = "Camp";
                    }
                    else if (budget>1000)
                    {
                        country = "Europe";
                        total = budget * 0.90;
                        type = "Hotel";
                    }
                    break;
                case "winter":
                    if (budget <= 100)
                    {
                        country = "Bulgaria";
                        total = budget * 0.70;
                        type = "Hotel";
                    }
                    else if (budget <= 1000)
                    {
                        country = "Balkans";
                        total = budget * 0.80;
                        type = "Hotel";
                    }
                    else if (budget > 1000)
                    {
                        country = "Europe";
                        total = budget * 0.90;
                        type = "Hotel";
                    }
                    break;
                    
                   
               
            }
            double sumAll = budget - total;
            
                Console.WriteLine($"Somewhere in {country}");
                Console.WriteLine($"{type} - {total:f2}");
            
        }
    }
}
