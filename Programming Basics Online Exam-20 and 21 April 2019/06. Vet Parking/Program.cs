using System;

namespace _06._Vet_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double pricePerHour = 0;
            double totalSum = 0;
            double hour = 0;
            double day = 0;
            for (int i = 0; i < days; i++)
            {
                day++;
                for (int j = 0; j < hours; j++)
                {
                    hour++;
                    if (day % 2 == 0 && hour % 2 == 1)
                    {
                        pricePerHour += 2.50;
                    }
                    else if (day % 2 == 1 && hour % 2 == 0)
                    {
                        pricePerHour += 1.25;
                    }
                    else
                    {
                        pricePerHour += 1;
                    }
                    if (hour == hours)
                    {
                        totalSum += pricePerHour;
                        Console.WriteLine($"Day: {day} - {pricePerHour:F2} leva");
                        pricePerHour = 0;
                        hour = 0;
                    }
                }
            }
            Console.WriteLine($"Total: {totalSum:F2} leva");
        }
    }
}
