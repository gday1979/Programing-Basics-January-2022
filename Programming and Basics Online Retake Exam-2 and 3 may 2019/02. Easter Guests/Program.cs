using System;

namespace _02._Easter_Guests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double guests = double.Parse(Console.ReadLine());
            double budget=double.Parse(Console.ReadLine());
            double egg = 0.45;
            double easterBread = 4;
            double countEggs = guests * 2;
            double countEasterBread = Math.Ceiling(guests / 3);
            double priceEggs = guests * 2 * egg;
            double priceEasterBread = countEasterBread*easterBread;
            double sum = priceEasterBread + priceEggs;
            double leftOver = budget - sum;
            if (budget>=sum)
            {
                Console.WriteLine($"Lyubo bought {countEasterBread} Easter bread and {countEggs} eggs.");
                Console.WriteLine($"He has {leftOver:f2} lv. left.");
            }
            else
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {-leftOver:f2} lv. more.");
            }

        }
    }
}
