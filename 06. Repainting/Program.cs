using System;

namespace _06._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double nylon=double.Parse(Console.ReadLine());
            double paint=double.Parse(Console.ReadLine());
            double thinner=double.Parse(Console.ReadLine());
            double hoursPerWork=double.Parse(Console.ReadLine());
            double priceNylon = (nylon + 2) * 1.50; ;
            double pricePaint = (paint *1.10)* 14.50;
            double priceThinner = thinner * 5;
            double bags = 0.40;
            double allSun = (priceNylon + pricePaint + priceThinner + bags);
            double sumPerMaster = (allSun * 0.30) * hoursPerWork;
            double finalSum = allSun + sumPerMaster;
            Console.WriteLine(finalSum);
        }
    }
}
