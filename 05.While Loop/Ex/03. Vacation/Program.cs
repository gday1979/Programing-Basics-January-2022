using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney=double.Parse(Console.ReadLine());
            double money=double.Parse(Console.ReadLine());
            int days = 0;
            int spend = 0;
            while (money<neededMoney&& spend<5)
            {
                string input = Console.ReadLine();
                double moneyForDays = double.Parse(Console.ReadLine());
                days++;
                if (input=="spend")
                {
                    spend++;
                    if (money-moneyForDays<0)
                    {
                        money = 0;
                    }
                    else
                    {
                        money-=moneyForDays;
                    }
                }
                else if (input=="save")
                {
                    money+=moneyForDays;
                    spend = 0;
                    
                }
            }
            if (spend==5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
            if (money >=neededMoney)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
