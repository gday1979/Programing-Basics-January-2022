using System;

namespace _01._Tennis_Equipmentt
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double budget=double.Parse(Console.ReadLine());
            double dunks = budget * 0.60;
            double team = dunks * 0.80;
            double ball = team * 0.25;
            double acssesories = ball * 0.20;
            double allsum=budget+dunks+team+ball+acssesories;
            Console.WriteLine($"{allsum:f2}");

        }
    }
}
