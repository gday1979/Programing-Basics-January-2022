using System;

namespace _05._Care_of_Puppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double foodSum = double.Parse(Console.ReadLine());
            foodSum *= 1000;
            double foodDog = 0;
            string input=Console.ReadLine();
            while (input != "Adopted")
            {
                double pupyFood = double.Parse(input);
                foodDog+=pupyFood;
                input = Console.ReadLine();
            }
            double leftovers = foodSum - foodDog;
            double needFood = foodDog - foodSum;
            if (foodSum>=foodDog)
            {
                Console.WriteLine($"Food is enough! Leftovers: {leftovers} grams.");
            }
            
            else if(foodDog>foodSum)
            {
                Console.WriteLine($"Food is not enough. You need {needFood} grams more.");
            }
        }
    }
}
