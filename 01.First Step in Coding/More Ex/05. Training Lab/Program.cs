using System;

namespace _05._Training_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());

            double w = double.Parse(Console.ReadLine());
            h = h * 100;
            w = w * 100;
            var h1 = Math.Floor(h / 120);
            var w1 = Math.Floor((w - 100) / 70);

            var reshenie = (w1 * h1) - 3;
            Console.WriteLine(reshenie); 
        }
    }
}
