using System;

namespace _07._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameArchitect = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int hoursToCreate = 3;
            int result = quantity * hoursToCreate;
            Console.WriteLine($"The architect {nameArchitect} will need {result} hours to complete {quantity} project/s.");
        }
    }
}
