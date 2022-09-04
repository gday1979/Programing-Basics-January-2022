using System;

namespace _01._Pipes_In_Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v=double.Parse(Console.ReadLine());
            double p1=double.Parse(Console.ReadLine());
            double p2=double.Parse(Console.ReadLine());
            double hour=double.Parse(Console.ReadLine());
            double sumP1 = p1 * hour;
            double sumP2 = p2 * hour;
            double sumAll=sumP1+sumP2;
            double procentP1 = (sumP1 / sumAll)*100;
            double procentP2 = (sumP2 / sumAll)*100;
            double procent = sumAll / v * 100;
            if (v>=sumAll)
            {
                Console.WriteLine($"The pool is {procent:f2}% full.Pipe 1: {procentP1:f2}%. Pipe 2: {procentP2:f2}%.");
            }
            else if (sumAll>v)
            {
                double tottal = sumAll - v;
                Console.WriteLine($"For {hour:f2} hours the pool overflows with {tottal:f2} liters.");
            }
        }
    }
}
