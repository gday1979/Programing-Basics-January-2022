using System;

namespace _05._Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double budget=double.Parse(Console.ReadLine());
            double count=double.Parse(Console.ReadLine());
          
            for (int i = 0; i < count; i++)
            {
                string film=Console.ReadLine();
                double price=double.Parse(Console.ReadLine());
                if (film=="Thrones")
                {
                    price *= 0.5;
                }
                else if (film=="Lucifer")
                {
                    price *= 0.6;
                }
                else if (film=="Protector")
                {
                    price *= 0.7;
                }
                else if (film=="TotalDrama")
                {
                    price *= 0.8;
                }
                else if (film=="Area")
                {
                    price *= 0.9;
                }
                else
                {
                    price *= 1.0;
                }
                budget -= price;
            }
            if (budget >=0)
            {
            
                Console.WriteLine($"You bought all the series and left with {budget:f2} lv.");
            }

            else 
            {
                
                Console.WriteLine($"You need {-budget:f2} lv. more to buy the series!");
            }
        }
    }
}
