using System;

namespace _04._Car_To_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season=Console.ReadLine();
            string carClass = "";
            string typeCar = "";
            if (budget <=100)
            {
                carClass = "Economy class";
                if (season=="Summer" && carClass=="Economy class")
                {
                    typeCar = "Cabrio";
                    budget *= 0.35;
               }
                else if (season=="Winter")
                {
                    typeCar = "Jeep";
                    budget *= 0.65;
                }
            }
            else if (budget>100 && budget <=500)
            {
                carClass = "Compact class";
                if (season=="Summer")
                {
                    typeCar = "Cabrio";
                    budget *= 0.45;
                }
                else if (season=="Winter")
                {
                    typeCar = "Jeep";
                    budget *= 0.80;
                }
            }
            else if (budget>500)
            {
                carClass = "Luxury class";
                if (season=="Summer" || season=="Winter")
                {
                    typeCar = "Jeep";
                    budget *= 0.90;
                }
            }
            Console.WriteLine($"{carClass}");
            Console.WriteLine($"{typeCar} - {budget:f2}");

        }
    }
}
