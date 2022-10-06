using System;

namespace _01._Movie_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string film=Console.ReadLine();
            double season = double.Parse(Console.ReadLine());
            double series=double.Parse(Console.ReadLine());
            double time=double.Parse(Console.ReadLine());
            double comersionalTime = time+ (time* 0.20);
            double extraTime = season * 10;
            double alltime=(comersionalTime*season*series)+extraTime;
            Console.WriteLine($"Total time needed to watch the {film} series is {alltime} minutes.");

        }
    }
}
