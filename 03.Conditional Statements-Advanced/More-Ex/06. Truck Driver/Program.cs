using System;

namespace _06._Truck_Driver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season=Console.ReadLine();
            double kilometersMonth=double.Parse(Console.ReadLine());
            double period = 4;
            double total = 0;
            if (kilometersMonth<=5000)
            {
                if (season=="Spring" || season=="Autumn")
                {
                    total = kilometersMonth * 0.75;
                }
                else if (season=="Summer")
                {
                    total = kilometersMonth * 0.90;
                }
                else if (season=="Winter")
                {
                    total = kilometersMonth * 1.05;
                }
            }
            else if (kilometersMonth>5000 && kilometersMonth<=10000)
            {
                if (season=="Spring" || season=="Autumn")
                {
                    total = kilometersMonth * 0.95;
                }
                else if (season=="Summer")
                {
                    total = kilometersMonth * 1.10;
                }
                else if (season=="Winter")
                {
                    total = kilometersMonth * 1.25;
                }
            }
            else if (kilometersMonth>10000 && kilometersMonth<=20000)
            {
                if (season=="Summer" ||season=="Autumn"|| season=="Winter" || season=="Spring")
                {
                    total = kilometersMonth * 1.45;
                }
            }
            double sumTotal = (total * period);
                double final = sumTotal - (sumTotal * 0.10);
           
            Console.WriteLine($"{final:f2}");
        }
    }
}
