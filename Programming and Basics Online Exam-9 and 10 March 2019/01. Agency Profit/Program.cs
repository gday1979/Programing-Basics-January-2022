using System;

namespace _01._Agency_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string avio=Console.ReadLine();
            double ticketsOlder=double.Parse(Console.ReadLine());
            double ticketsYoung=double.Parse(Console.ReadLine());   
            double price=double.Parse(Console.ReadLine());
            double taxes=double.Parse(Console.ReadLine());
            double priceOlder = price + taxes;
            double priceYoung = price * 0.30+taxes;
            double total= (ticketsYoung * priceYoung) + (ticketsOlder * priceOlder);
            double profit = total * 0.20;
            Console.WriteLine($"The profit of your agency from {avio} tickets is {profit:f2} lv.");
        }
    }
}
