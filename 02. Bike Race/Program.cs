using System;

namespace _02._Bike_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            double sumJuniors = 0;
            double sumSeniors = 0;
            double peopleRide = juniors + seniors;
            
                switch (type)
                {
                    case "trail":
                        sumJuniors = juniors * 5.50;
                        sumSeniors = seniors * 7.00;
                        break;
                    case "cross-country":
                        sumJuniors = juniors * 8;
                    sumSeniors = seniors * 9.50;
                        break;
                    case "downhill":
                        sumJuniors = juniors * 12.25;
                    sumSeniors = seniors * 13.75;
                        break;
                    case "road":
                        sumJuniors = juniors * 20;
                    sumSeniors = seniors * 21.50;
                    break;
                }
            
            double total = sumJuniors + sumSeniors;
            if (peopleRide >=50 && type=="cross-country")
            {
                total = total - (total * 0.25);
            }

            double discount = total - (total * 0.05);
            Console.WriteLine($"{discount:f2}");
        }
    }
}
