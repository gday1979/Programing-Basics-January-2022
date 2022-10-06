using System;

namespace _05._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget=double.Parse(Console.ReadLine());
            string season=Console.ReadLine();
            string location = "";
            string type = "";
            if (budget<=1000)
            {
                type = "Camp";
                if (season=="Summer")
                {
                    location = "Alaska";
                    budget *= 0.65;
                }
                else if (season=="Winter")
                {
                    location = "Morocco";
                    budget *= 0.45;
                }
            }
            else if (budget>1000 && budget <=3000)
            {
                type = "Hut";
                if (season=="Summer")
                {
                    location = "Alaska";
                    budget *= 0.80;
                }
                else if (season=="Winter")
                {
                    location = "Morocco";
                    budget *= 0.60;
                }
            }
            else if (budget>3000)
            {
                type = "Hotel";
                if (season=="Summer")
                {
                    location = "Alaska";
                    budget *= 0.90;
                }
                else if (season=="Winter")
                {
                    location = "Morocco";
                    budget *= 0.90;
                }
            }
            Console.WriteLine($"{location} - {type} - {budget:f2}");
        }
    }
}
