using System;

namespace _11._HappyCat_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int days=int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double sumТoPay = 0;
            double totalSum = 0;
            for (int daysCount = 1; daysCount <=days; daysCount++)
            {
                for (int hoursCount = 1; hoursCount <=hours; hoursCount++)
                {
                    if (daysCount%2==0 && hoursCount % 2 !=0)
                    {
                        totalSum += 2.50;
                        sumТoPay += 2.50;
                    }
                    else if (daysCount %2!=0 && hoursCount %2==0)
                    {
                        totalSum += 1.25;
                        sumТoPay += 1.25;
                    }
                    else
                    {
                        totalSum += 1;
                        sumТoPay += 1;
                    }
                }
                Console.WriteLine($"Day: {daysCount} - {totalSum:f2} leva");
                totalSum = 0;
                
            }
            Console.WriteLine($"Total: {sumТoPay:f2} leva");
        }
    }
}
