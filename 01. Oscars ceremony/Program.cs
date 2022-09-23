using System;

namespace _01._Oscars_ceremony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceHall = double.Parse(Console.ReadLine());
            double oscarStatuete = priceHall-(priceHall * 0.30);
            double catering = oscarStatuete - (oscarStatuete * 0.15);
            double voising = catering * 0.50;
            double allSum=priceHall+oscarStatuete+catering+voising;
            Console.WriteLine($"{allSum:f2}");
        }
    }
}
