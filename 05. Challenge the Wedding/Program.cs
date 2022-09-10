using System;

namespace _05._Challenge_the_Wedding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int tablesMax = int.Parse(Console.ReadLine());
            int tableCounter = 0;

            for (int m = 1; m <= men; m++)
            {
                for (int f = 1; f <= women; f++)
                {
                    Console.Write($"({m} <-> {f}) ");
                    tableCounter++;
                    if (tableCounter == tablesMax)
                    {
                        return;
                    }
                }
            }
        }
    }
}
