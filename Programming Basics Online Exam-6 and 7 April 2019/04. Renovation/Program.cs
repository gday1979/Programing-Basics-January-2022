using System;

namespace _04._Renovation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height = int.Parse(Console.ReadLine());
            double width = int.Parse(Console.ReadLine());
            double percentageWindowsAndDoors = int.Parse(Console.ReadLine());

            double totalArea = height * width * 4;
            totalArea = Math.Ceiling(totalArea - (totalArea / 100 * percentageWindowsAndDoors));

            string input = Console.ReadLine();
            while (input != "Tired!")
            {
                double litersUsed = double.Parse(input);

                totalArea -= litersUsed;

                if (totalArea <= 0)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (totalArea == 0)
            {
                Console.WriteLine($"All walls are painted! Great job, Pesho!");
            }
            else if (input == "Tired!")
            {
                Console.WriteLine($"{totalArea} quadratic m left.");
            }
            else
            {
                Console.WriteLine($"All walls are painted and you have {Math.Abs(totalArea)} l paint left!");
            }
        }
    }
}
