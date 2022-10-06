using System;

namespace _06._Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double month=double.Parse(Console.ReadLine());
            double sum = 0;
            double water = 20;
            double net = 15;
            double others = 0;
            for (int i = 0; i < month; i++)
            {
                double voltage = double.Parse(Console.ReadLine());
                sum += voltage;
            }
            water *= month;
            net *= month;
            double allSum = sum + water + net;
            others = allSum * 1.20;
            double average = (allSum + others) / month;
            Console.WriteLine($"Electricity: {sum:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {net:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
