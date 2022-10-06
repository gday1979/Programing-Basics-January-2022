using System;

namespace _01._Birthday_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget=double.Parse(Console.ReadLine());
            double cake = budget * 0.20;
            double drinks = cake * 0.55;
            double animator = budget / 3;
            double allSum=budget+cake+drinks+animator;
            Console.WriteLine(allSum);
        }
    }
}
