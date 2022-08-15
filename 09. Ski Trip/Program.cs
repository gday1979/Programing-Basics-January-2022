using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string opinion = Console.ReadLine();

            int nights = days - 1;
            double price = 0;
            if (room == "room for one person")
            {
                price = nights * 18;

            }
            else if (room == "apartment")
            {
                price = nights * 25;
                if (days < 10)
                {
                    price = price - 0.3 * price;
                }
                else if (nights >= 10 && nights <= 15)
                {
                    price = price - 0.35 * price;
                }
                else if (nights > 15)
                {
                    price = price - price * 0.50;
                }
            }
            else if (room == "president apartment")
            {
                price = nights * 35;
                if (nights < 10)
                {
                    price = price - 0.10 * price;
                }
                else if (nights >= 10 && nights <= 15)
                {
                    price = price - 0.15 * price;
                }
                else if (nights > 15)
                {
                    price = price - 0.20 * price;
                }

            }
            if (opinion == "positive")
            {
                price = price + 0.25 * price;
            }
            else if (opinion == "negative")
            {
                price = price - 0.10 * price;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
