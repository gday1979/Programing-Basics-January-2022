using System;

namespace _03._Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int hrizantenium=int.Parse(Console.ReadLine());
            int rose=int.Parse(Console.ReadLine());
            int tulip=int.Parse(Console.ReadLine());
            string season=Console.ReadLine();
            string day=Console.ReadLine();
            double priceHrizantenium = 0;
            double priceTulip = 0;
            double priceRose = 0;
            double allQuantity = rose + tulip + rose;
            double arangment = 2;
            switch (season)
            {
                case "Spring":
                case "Summer":
                    priceHrizantenium = hrizantenium * 2.00;
                    priceRose = rose * 4.10;
                    priceTulip = tulip * 2.50;
                    break;
                case "Autumn":
                case "Winter":
                    priceHrizantenium = hrizantenium * 3.75;
                    priceRose = rose * 4.50;
                    priceTulip = tulip * 4.15;
                    break;
            }
            double total = priceHrizantenium + priceRose + priceTulip;
            if (day=="Y")
            {
                total = total + (total * 0.15);
            }
            if (tulip>7 && season=="Spring")
            {
                total = total - (total * 0.05);
            }
            if (rose>=10 && season=="Winter")
            {
                total = total - (total * 0.10);
            }
            if (allQuantity>20)
            {
                total = total - (total * 0.20);
            }
            double finalSum = total + arangment;
            Console.WriteLine($"{finalSum:f2}");
        }
    }
}
