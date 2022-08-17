using System;

namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numbers=int.Parse(Console.ReadLine());
            int MinN = int.MaxValue;
            int MaxN = int.MinValue;
            for (int i = 0; i < numbers; i++)
            {
                int num=int.Parse(Console.ReadLine());
                if (num<MinN)
                {
                    MinN = num;
                }
                if (num>MaxN)
                {
                    MaxN = num;
                }
            }
            Console.WriteLine($"Max number: {MaxN}");
            Console.WriteLine($"Min number: {MinN}");
        }
    }
}
