using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double days = double.Parse(Console.ReadLine());
            double priceApartment = 0.00;
            double priceStudio = 0.00;
            double totalApartment = 0.00;
            double totalStudio = 0.00;
            if (month == "May" || month == "Octomber")
            {
                priceApartment = days * 65;
                priceStudio = days * 50;
                if (days>14)
                {
                    totalStudio = priceStudio * 0.30;
                    totalApartment = priceApartment * 0.10;
                }
                else if (days >7 || days <14)
                {
                    
                    totalStudio = priceStudio * 0.05;
                }
            }
            else if (month == "June" || month == "September")
            {
                priceApartment = days * 68.70;
                priceStudio = days * 75.20;
                if (days > 14)
                {
                    totalStudio = priceStudio * 0.20;
                    totalApartment = priceApartment * 0.10;
                }
            }
            else if (month == "July" || month == "August")
            {
                priceApartment = days * 77;
                priceStudio = days * 76;
                if (days > 14)
                {
                    totalApartment = priceApartment * 0.10;
                }
            }
            double sumApartment = priceApartment - totalApartment;
            double sumStudio = priceStudio - totalStudio;
            Console.WriteLine($"Apartment: {sumApartment:f2} lv.");
            Console.WriteLine($"Studio: {sumStudio:f2} lv.");
        }
    }
}
