using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers=Console.ReadLine();  
            double quantity=double.Parse(Console.ReadLine());
            double budget=double.Parse(Console.ReadLine());
            double price = 0.0;
            double sum=0.0;
            if (flowers=="Roses")
            {
                price = quantity * 5;
                if (quantity>80)
                {
                    sum = price* 0.10;
                }
                    
            }
            else if (flowers=="Dalia")
            {
                price = quantity * 3.80;
                if (quantity>90)
                {
                    sum = price*0.15; 
                }
            }
            else if (flowers=="Tulips")
            {
                price = quantity * 2.80;
                if (quantity>80)
                {
                    sum = price*0.15;
                }
            }
            else if (flowers=="Narcissus")
            {
                price = quantity * 3;
                if (quantity<120)
                {
                    sum = price* 0.15;
                }

            }
            else if (flowers=="Gladiolus")
            {
                price = quantity * 2.50;
                if (quantity<80)
                {
                    sum = price* 0.20;
                }
            }
            double amount = (sum + price);
            if (budget>amount)
            {
                double result = budget -amount;
                Console.WriteLine($"Hey, you have a great garden with {quantity} {flowers} and {Math.Abs(result):f2} leva left.");
            }
            else 
            {
                double result = price - budget;
                Console.WriteLine($"Not enough money, you need {result:f2} leva more.");
            }
            
        }
    }
}
