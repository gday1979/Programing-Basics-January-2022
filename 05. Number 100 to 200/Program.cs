using System;

namespace _05._Number_100_to_200
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int numbers=int.Parse(Console.ReadLine());
            if (numbers>200)
            {
                Console.WriteLine("Greater than 200");
            }
            else if (numbers >= 100 && numbers <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (numbers <100)
            {
                Console.WriteLine("Less than 100");
            }
        }
    }
}
