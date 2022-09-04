using System;

namespace _05._Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days=int.Parse(Console.ReadLine());
            int foodKg=int.Parse(Console.ReadLine());
            double foodDog=double.Parse(Console.ReadLine());
            double foodCat=double.Parse(Console.ReadLine());
            double foodTurtle=double.Parse(Console.ReadLine());
            foodTurtle = foodTurtle / 1000;
            double allFood = (foodDog*days) + (foodCat*days) + (foodTurtle*days);
            double restFood = foodKg - allFood;
            double needFood = allFood - foodKg;
            if (foodKg>=allFood)
            {
                Console.WriteLine($"{Math.Floor(restFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(needFood)} more kilos of food are needed.");
            }
        }
    }
}
