using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double videoCards = double.Parse(Console.ReadLine());
            double procesor = double.Parse(Console.ReadLine());
            double ram = double.Parse(Console.ReadLine());
            double priceVideoCards = videoCards * 250;
            double priceProcesor =procesor*( priceVideoCards * 0.35);
            double priceRam = ram * (priceVideoCards * 0.10);
            double allASum = priceVideoCards + priceProcesor + priceRam;
            
            if (videoCards > procesor)
            {
                allASum = allASum-(allASum * 0.15);


            }
            double diference = budget - allASum;


                if (diference >=0)
                {
                    
                    Console.WriteLine($"You have {diference:f2} leva left!");
                }
                else 
                {
                   

                    Console.WriteLine($"Not enough money! You need {Math.Abs(diference):f2} leva more!");
                }
            
        }
    }
}
