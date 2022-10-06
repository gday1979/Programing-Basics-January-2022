using System;

namespace _02._Report_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int expectedSum=int.Parse(Console.ReadLine());
            string command = "";
            int transactionsCounter = 0;
            int cash = 0;
            int transCash = 0;
            int card = 0;
            int transCard = 0;
            while ((command=Console.ReadLine()) !="End" && cash+card<expectedSum)
            {
                int itemPrice=int.Parse(command);
                if (transactionsCounter++ %2==0)
                {
                    if (itemPrice>100)
                    {
                        Console.WriteLine($"Error in transaction!");
                    }
                    else
                    {
                        transCash++;
                        cash+=itemPrice;
                        Console.WriteLine($"Product sold!");
                    }
                }
                else
                {
                    if (itemPrice<10)
                    {
                        Console.WriteLine($"Error in transaction!");
                    }
                    else
                    {
                        transCard++;
                        card += itemPrice;
                        Console.WriteLine($"Product sold!");
                    }
                }
            }
            if (command=="End")
            {
                Console.WriteLine($"Failed to collect required money for charity.");
            }
            else
            {
                double totalSumCash = cash * 1.0 / transCash;
                double totalSumCard= card * 1.0 / transCard;
                Console.WriteLine($"Average CS: {totalSumCash:f2}");
                Console.WriteLine($"Average CC: {totalSumCard:f2}");
            }
        }
    }
}
