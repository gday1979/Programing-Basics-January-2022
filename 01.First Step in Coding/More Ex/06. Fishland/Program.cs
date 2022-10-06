using System;

namespace _06._Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double priceMacharel=double.Parse(Console.ReadLine());
            double priceFishyCaca=double.Parse(Console.ReadLine());
            double bonitoKg=double.Parse(Console.ReadLine());
            double skadKg=double.Parse(Console.ReadLine());
            double mussel=double.Parse(Console.ReadLine());
           double sumBonito = bonitoKg*(priceMacharel + priceMacharel * 0.60);
            double sumSkad =skadKg* (priceFishyCaca + priceFishyCaca * 0.80);
           double sumMussel = mussel*7.50;
            double allSum=sumBonito+sumSkad+sumMussel;
            Console.WriteLine($"{allSum:f2}");
        }
    }
}
