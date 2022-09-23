using System;

namespace _05._PC_Game_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n=int.Parse(Console.ReadLine());
            double counterHearth = 0;
            double counterFortnite = 0;
            double counterOverwatch = 0;
            double counterOthers=0;
            
            for (int i = 0; i < n; i++)
            {
                string games = Console.ReadLine();
                if (games=="Hearthstone")
                {
                    counterHearth++;
                }
                else if (games=="Fornite")
                {
                    counterFortnite++;
                }
                else if (games=="Overwatch")
                {
                    counterOverwatch++;
                }
                else 
                {
                    counterOthers++;
                }

            }
            
            Console.WriteLine($"Hearthstone - {counterHearth/n*100:f2}%");
            Console.WriteLine($"Fornite - {counterFortnite/n*100:f2}%");
            Console.WriteLine($"Overwatch - {counterOverwatch/n*100:f2}%");
            Console.WriteLine($"Others - {counterOthers/n*100:f2}%");
        }
    }
}
