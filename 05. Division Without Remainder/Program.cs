using System;
using System.Globalization;

namespace _05._Division_Without_Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            for (int i = 0; i < n; i++)
            {
                double numbers = double.Parse(Console.ReadLine());
                if (numbers % 2 == 0)
                {
                    p1++;
                }
                if (numbers % 3 == 0)
                {
                    p2++;
                }
                if (numbers % 4 == 0)
                {
                    p3++;
                }
            }
            Console.WriteLine($"{p1/n*100:f2}%");
            Console.WriteLine($"{p2/n*100:f2}%");
            Console.WriteLine($"{p3/n*100:f2}%");
        }
    }
}
