using System;

namespace _03._Oscars_week_in_cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameFilm = Console.ReadLine();
            string typeTicket = Console.ReadLine();
            double ticket = int.Parse(Console.ReadLine());
            double sum = 0;
            if (nameFilm == "A Star Is Born")
            {
                if (typeTicket == "normal")
                {
                    sum =ticket* 7.50;
                }
                else if (typeTicket == "luxury")
                {
                    sum = ticket * 10.50;
                }
                else if (typeTicket == "ultra luxury")
                {
                    sum=ticket *13.50;
                }
            }
            else if (nameFilm == "Bohemian Rhapsody")
            {

                if (typeTicket == "normal")
                {
                    sum=ticket *7.35;
                }
                else if (typeTicket == "luxury")
                {
                    sum=ticket *9.45;
                }
                else if (typeTicket == "ultra luxury")
                {
                    sum=ticket * 12.75;
                }
            }
            else if (nameFilm=="Green Book")
            {
                if (typeTicket == "normal")
                {
                    sum=ticket * 8.15;
                }
                else if (typeTicket == "luxury")
                {
                   sum= ticket *10.25;
                }
                else if (typeTicket == "ultra luxury")
                {
                    sum=ticket *13.25;
                }
            }
            else if (nameFilm=="The Favourite")
            {
                if(typeTicket == "normal")
                {
                   sum= ticket *8.75;
                }
                else if (typeTicket == "luxury")
                {
                    sum=ticket *11.55; ;
                }
                else if (typeTicket == "ultra luxury")
                {
                    sum=ticket *13.95;
                }
            }

            Console.WriteLine($"{nameFilm} -> {sum:f2} lv.");
        }

    }
}
