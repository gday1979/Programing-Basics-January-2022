using System;

namespace _04._Easter_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eggs = int.Parse(Console.ReadLine());
            bool closed = true;
            int eggsBought = 0;

            string input = Console.ReadLine();
            while (input != "Close")
            {
                if (input == "Buy")
                {
                    int quantity = int.Parse(Console.ReadLine());
                    if (eggs < quantity)
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine("You can buy only {0}.", eggs);
                        closed = false;
                        break;
                    }
                    eggsBought += quantity;
                    eggs -= quantity;
                }
                if (input == "Fill") eggs += int.Parse(Console.ReadLine());

                input = Console.ReadLine();
            }
            if (closed)
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine("{0} eggs sold.", eggsBought);
            }
        }
    }

}