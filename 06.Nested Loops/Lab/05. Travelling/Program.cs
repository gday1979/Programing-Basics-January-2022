using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string country = Console.ReadLine();
                double sum = 0;
                if (country=="End")
                {
                    break;
                }

                double neededMoney = double.Parse(Console.ReadLine());

                while (sum<neededMoney)
                {
                    double input=double.Parse(Console.ReadLine());

                    sum += input;
                }
                Console.WriteLine($"Going to {country}!");
            }

        }
    }
}
