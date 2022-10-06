using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string type=Console.ReadLine();  
            double rows=double.Parse(Console.ReadLine());
            double columns=double.Parse(Console.ReadLine());
            
            double income = 0.0;
            if (type=="Premiere")
            {
                income = rows * columns * 12;
            }
            else if (type=="Normal")
            {
                income = rows * columns * 7.50;
            }
            else if (type=="Discount")
            {
                income = rows * columns * 5;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
