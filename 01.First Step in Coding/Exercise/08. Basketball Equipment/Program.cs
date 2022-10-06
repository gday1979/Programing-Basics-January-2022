using System;

namespace _08._Basketball_Equipment
{
    class Program5
    {
        static void Main(string[] args)
        {
            int priceYear=int.Parse(Console.ReadLine());
            double priceSneakers = priceYear-(priceYear*0.40);
            double priceTeam = priceSneakers-(priceSneakers*0.20) ;
            double priceBall = priceTeam  * 0.25;
            double priceAccessories = priceBall * 0.20;
            double sum = priceYear+priceSneakers + priceTeam + priceBall + priceAccessories;
            Console.WriteLine(sum);
        }
    }
}
