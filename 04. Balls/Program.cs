using System;

namespace _04._Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count=int.Parse(Console.ReadLine());
            int countRed = 0;
            int countOrange = 0;
            int countYellow = 0;
            int countWhite = 0;
            int countOther = 0;
            int divideByBlack = 0;
            int points = 0;
            for (int i = 0; i < count; i++)
            {
                string balls = (Console.ReadLine());
                if (balls=="red")
                {
                    points += 5;
                    countRed++;
                }
                else if (balls=="orange")
                {
                    points += 10;
                    countOrange++;
                }
                else if (balls=="yellow")
                {
                    points += 15;
                    countYellow++;
                }
                else if (balls=="white")
                {
                    points += 20;
                    countWhite++;
                }
                else if (balls=="black")
                {
                    points /= 2;
                    divideByBlack++;
                }
                else
                {
                    countOther++;
                }
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {countRed}");
            Console.WriteLine($"Orange balls: {countOrange}");
            Console.WriteLine($"Yellow balls: {countYellow}");
            Console.WriteLine($"White balls: {countWhite}");
            Console.WriteLine($"Other colors picked: {countOther}");
            Console.WriteLine($"Divides from black balls: {divideByBlack}");
        }
    }
}
