using System;

namespace _03._Easter_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string country=Console.ReadLine();
            string days=Console.ReadLine();
            double nights=double.Parse(Console.ReadLine());
            double sum = 0;
            if (country=="France")
            {
                if (days=="21-23")
                {
                    sum = nights * 30;
                }
                else if (days=="24-27")
                {
                    sum = nights * 35;
                }
                else if (days=="28-31")
                {
                    sum = nights * 40;
                }
            }
            else if (country=="Italy")
            {
                if (days == "21-23")
                {
                    sum = nights * 28;
                }
                else if (days == "24-27")
                {
                    sum = nights * 32;
                }
                else if (days == "28-31")
                {
                    sum = nights * 39;
                }
            }
            else if (country=="Germany")
            {
                if (days == "21-23")
                {
                    sum = nights * 32;
                }
                else if (days == "24-27")
                {
                    sum = nights * 37;
                }
                else if (days == "28-31")
                {
                    sum = nights * 43;
                }
            }
            Console.WriteLine($"Easter trip to {country} : {sum:f2} leva.");
        }
    }
}
