using System;

namespace _04._Vegetable_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceVegetable = double.Parse(Console.ReadLine());
            double priceFruit=double.Parse(Console.ReadLine());
            double sumVegetable=double.Parse(Console.ReadLine());
            double sumFruit=double.Parse((Console.ReadLine()));
            double euro = 1.94;
            double all = (priceVegetable * sumVegetable) + (priceFruit * sumFruit);
            double result = all / euro;
            Console.WriteLine($"{result:f2}");
        }
    }
}
