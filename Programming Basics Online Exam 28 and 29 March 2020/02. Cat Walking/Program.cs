using System;

namespace _02._Cat_Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutesPerWalk=int.Parse(Console.ReadLine());
            int quantityWalk=int.Parse(Console.ReadLine());
            int caloriesPerDay=int.Parse(Console.ReadLine());
            int burntCalories = minutesPerWalk * quantityWalk * 5;
            int procenyCalories= caloriesPerDay/2 ;
            if (burntCalories>=procenyCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burntCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burntCalories}.");
            }
        }
    }
}
