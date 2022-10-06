using System;

namespace _01._Series_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string film=Console.ReadLine();
            double days=double.Parse(Console.ReadLine());
            double ticket=double.Parse(Console.ReadLine());
            double price=double.Parse(Console.ReadLine());
            double chargeCinema=double.Parse(Console.ReadLine());
            double allSum = ticket * price * days;
            double sum = allSum - (allSum * chargeCinema/100);
            Console.WriteLine($"The profit from the movie {film} is {sum:f2} lv.");
        }
    }
}
