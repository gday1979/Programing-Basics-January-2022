using System;

namespace _02._Easter_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double guests=double.Parse(Console.ReadLine());
            double priceForOne=double.Parse(Console.ReadLine());
            double budget=double.Parse(Console.ReadLine());
            double sum = 0;
            double priceCake = budget * 0.10;
            if (guests>=10 && guests<=15)
            {
                priceForOne *= 0.85;
            }
            else if (guests>15 && guests<=20)
            {
                priceForOne *= 0.80;
            }
            else if (guests>20)
            {
                priceForOne *= 0.75;
            }
            sum=guests*priceForOne+priceCake;
            double leftOver = budget - sum;
            if (budget>=sum)
            {
                Console.WriteLine($"It is party time! {leftOver:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {-leftOver:f2} leva needed.");
            }
        }
    }
}
