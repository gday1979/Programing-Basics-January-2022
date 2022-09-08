using System;

namespace _08._Equal_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int min = Int32.MaxValue;
            int max = Int32.MinValue;

            for (int i = 0; i < n; i++)
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                sum = number1 + number2;


                if (sum < min)
                {
                    min = sum;
                }
                if (sum > max)
                {
                    max = sum;
                }
            }
            if (min != max)
            {
                Console.WriteLine($"No, maxdiff={max-min}");
            }
            else
            {
                Console.WriteLine($"Yes, value={sum}");
            }


        }
    }
}
