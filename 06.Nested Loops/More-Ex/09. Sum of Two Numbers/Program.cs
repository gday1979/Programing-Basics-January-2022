using System;
using System.Reflection;

namespace _09._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int startIndex=int.Parse(Console.ReadLine());
            int endIndex=int.Parse(Console.ReadLine());
            int magicNumber=int.Parse(Console.ReadLine());
            int combinations = 0;
            for (int i = startIndex; i<=endIndex; i++)
            {
                for (int j = startIndex; j <=endIndex; j++)
                {
                    
                    combinations++;
                    if (i+j==magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
        }
    }
}
