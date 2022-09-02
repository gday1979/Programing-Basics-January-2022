using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isMagicNumberFound = false;
            for (int i = numberOne; i <= numberTwo; i++)
            {
                for (int j = numberOne; j <= numberOne; j++)
                {
                    counter++;


                    if (numberOne + numberOne == magicNumber)
                    {
                        isMagicNumberFound = true;
                        Console.WriteLine($"Combination N:{counter} ({numberOne} + {numberTwo} = {magicNumber}");
                        return;
                    }
                }
            }
            if (!isMagicNumberFound)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
