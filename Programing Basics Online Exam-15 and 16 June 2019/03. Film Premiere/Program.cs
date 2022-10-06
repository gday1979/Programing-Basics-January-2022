using System;

namespace _03._Film_Premiere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string film=Console.ReadLine();
            string packageFilm=Console.ReadLine();
            int ticket=int.Parse(Console.ReadLine());
            double price = 0;
            switch (film)
            {
                case "John Wick":
                    if (packageFilm=="Drink")
                    {
                        price = ticket * 12;
                    }
                    else if (packageFilm=="Popcorn")
                    {
                        price = ticket * 15;
                    }
                    else if (packageFilm=="Menu")
                    {
                        price = ticket * 19;
                    }
                    break;
                case "Star Wars":
                    if (packageFilm == "Drink")
                    {
                        price = ticket * 18;
                    }
                    else if (packageFilm == "Popcorn")
                    {
                        price = ticket * 25;
                    }
                    else if (packageFilm == "Menu")
                    {
                        price = ticket * 30;
                    }
                    break;
                case "Jumanji":
                    if (packageFilm == "Drink")
                    {
                        price = ticket * 9;
                    }
                    else if (packageFilm == "Popcorn")
                    {
                        price = ticket * 11;
                    }
                    else if (packageFilm == "Menu")
                    {
                        price = ticket * 14;
                    }
                    break;

                default:
                    break;
                   
            }
            
            if (film=="Star Wars" && ticket>=4)
            {
                price *= 0.70;
            }
            if (film=="Jumanji" && ticket==2)
            {
                price *= 0.85;
            }
            Console.WriteLine($"Your bill is {price:f2} leva.");
        }
    }
}
