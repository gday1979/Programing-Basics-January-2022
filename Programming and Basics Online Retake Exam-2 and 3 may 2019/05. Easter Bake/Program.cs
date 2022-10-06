using System;

namespace _05._Easter_Bake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count=int.Parse(Console.ReadLine());
            double packageSugar = 950;
            double packageFlour = 750;
            double sumSugar = 0;
            double sumFlour = 0;
            double maxSugar = 0;
            double maxFlour = 0;


            for (int i = 0; i < count; i++)
            { 

                double sugar = double.Parse(Console.ReadLine());
                double flour=double.Parse(Console.ReadLine());
                if (sugar>maxSugar)
                {
                    maxSugar = sugar; 
                }
                if (flour>maxFlour)
                {
                    maxFlour = flour;
                }
                
                sumSugar += sugar;
                sumFlour+=flour;
                sugar = 0;
                flour = 0;
                
            }
            Console.WriteLine($"Sugar: {Math.Ceiling(sumSugar/packageSugar)}");
            Console.WriteLine($"Flour: {Math.Ceiling(sumFlour/packageFlour)}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
        }
    }
}
