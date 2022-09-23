using System;

namespace _02._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget=double.Parse(Console.ReadLine());
            double extraMan=double.Parse(Console.ReadLine());
            double clothes=double.Parse(Console.ReadLine());
            double decor= budget * 0.10;
            double priceExtraMan = extraMan * clothes;
            if (extraMan>150)
            {
                priceExtraMan *= 0.90;
            }
            double allSum=decor + priceExtraMan;
            if (allSum>budget)
            {
                double needMoney=allSum-budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {needMoney:f2} leva more.");
            }
            else if (budget>=allSum)
            {
                double money = budget - allSum;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {money:f2} leva left.");
            }
        }
    }
}
