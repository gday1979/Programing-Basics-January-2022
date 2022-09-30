using System;

namespace _05._Suitcases_Load
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double suitcasesSum = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double suit = 0;
            int countLuggage = 0;
            while (input != "End")
            {
                double quantityLuggage = double.Parse(input);
                countLuggage++;
                if (countLuggage % 3 == 0)
                {
                    suit += quantityLuggage * 1.1;
                }
                else suit += quantityLuggage;
                input = Console.ReadLine();

                if (suitcasesSum < suit)
                {
                    Console.WriteLine("No more space!");
                    countLuggage--;
                    break;
                }
            }
            if (suitcasesSum >= suit)
            {

                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {countLuggage} suitcases loaded.");

        }
    }
}
