using System;

namespace _08._Secret_Door_s_Lock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upperHundreds = int.Parse(Console.ReadLine());
            int upperTens = int.Parse(Console.ReadLine());
            int upperOnes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= upperHundreds; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 1; j <= upperTens; j++)
                    {
                        if (j == 2 || j == 3 || j == 5 || j == 7)
                        {
                            for (int k = 1; k <= upperOnes; k++)
                            {
                                if (k % 2 == 0)
                                {
                                    Console.WriteLine($"{i} {j} {k} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
