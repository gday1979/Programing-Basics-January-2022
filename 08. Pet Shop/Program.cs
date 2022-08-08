using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodDogs = double.Parse(Console.ReadLine());
            double foodCat = double.Parse(Console.ReadLine());
            double priceFoodDogs = foodDogs * 2.50;
            double pricefoodCat = foodCat * 4;
            double sumAll = priceFoodDogs + pricefoodCat;
            Console.WriteLine($"{sumAll} lv.");

        }
    }
}
