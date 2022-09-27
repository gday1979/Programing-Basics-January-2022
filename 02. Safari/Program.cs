using System;

namespace _02._Safari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget=double.Parse(Console.ReadLine());
            double fuel=double.Parse(Console.ReadLine());
            string day=Console.ReadLine();
            double fuelPrice = fuel*2.10;
            double tourGuide = 100;
            double sumFor = fuelPrice + tourGuide;
            
            if (day=="Saturday")
            {
                sumFor *= 0.90;
                budget-=sumFor;
            }
            else if (day=="Sunday")
            {
                sumFor *= 0.80;
                budget -=sumFor;
            }
            else
            {
                budget -= sumFor;
            }
            if (budget>0)
            {
                
                Console.WriteLine($"Safari time! Money left: {budget:f2} lv.");
            }
            else 
            {
                
                Console.WriteLine($"Not enough money! Money needed: {-budget:f2} lv.");
            }
        }
    }
}
