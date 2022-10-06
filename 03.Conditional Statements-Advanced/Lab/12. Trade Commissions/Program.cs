using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sum=double.Parse(Console.ReadLine());
            double discounSum=0.00;
            if (city == "Sofia")
            {
                if (sum > 10000)
                {
                    discounSum = sum * 0.12;
                }
                else if (sum > 1000 && sum <= 10000)
                {
                    discounSum = sum * 0.08;
                }
                else if (sum > 500 && sum <= 1000)
                {
                    discounSum = sum * 0.07;
                }
                else if (sum > 0 && sum <= 500)
                {
                    discounSum = sum * 0.05;
                }
            }
            else if (city == "Varna")
            {
                if (sum > 10000)
                {
                    discounSum = sum * 0.13;
                }
                else if (sum > 1000 && sum <= 10000)
                {
                    discounSum = sum * 0.10;
                }
                else if (sum > 500 && sum <= 1000)
                {
                    discounSum = sum * 0.075;
                }
                else if (sum > 0 && sum <= 500)
                {
                    discounSum = sum * 0.045;
                }

            }
            else if (city == "Plovdiv")
            {
                if (sum > 10000)
                {
                    discounSum = sum * 0.145;
                }
                else if (sum > 1000 && sum <= 10000)
                {
                    discounSum = sum * 0.12;
                }
                else if (sum > 500 && sum <= 1000)
                {
                    discounSum = sum * 0.08;
                }
                else if (sum > 0 && sum <= 500)
                {
                    discounSum = sum * 0.055;
                }

                else
                {
                    Console.WriteLine("error");
                    return;
                }
                Console.WriteLine($"{discounSum:f2}");
            }
        }
    }
}
