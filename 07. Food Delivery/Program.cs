using System;

namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
           int chickenMenu=int.Parse(Console.ReadLine());   
            int fishMenu=int.Parse(Console.ReadLine()); 
            int vegeterianMenu=int.Parse(Console.ReadLine());
            double priceChicken = chickenMenu * 10.35;
            double priceFish = fishMenu * 12.40;
            double priceVege = vegeterianMenu * 8.15;
            double delivery = 2.50;
            double desert = (priceChicken + priceFish + priceVege) * 0.20;
            double sum = priceChicken + priceFish + priceVege + delivery + desert;
            Console.WriteLine(sum);
        }
    }
}
