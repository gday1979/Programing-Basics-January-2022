using System;
using System.Security;

namespace _03._World_Snooker_Championship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stage=Console.ReadLine();
            string typeTicket=Console.ReadLine();
            double priceTicket=double.Parse(Console.ReadLine());
            string fotoWithTrophy=Console.ReadLine();
            double fotoWithoutTrophy = 40;
            double sum = 0;
            bool wantPhot=false;
            if (fotoWithTrophy == "Y") wantPhot = true;
            if (stage=="Quarter final")
            {
                if (typeTicket == "Standard") sum=priceTicket * 55.50;
                else if (typeTicket == "Premium") sum=priceTicket * 105.20;
                else if (typeTicket == "VIP") sum=priceTicket * 118.90;
                
            }
            else if (stage=="Semi final")
            {
                if (typeTicket == "Standard") sum=priceTicket * 75.88;
                else if (typeTicket == "Premium") sum=priceTicket * 125.22;
                else if (typeTicket == "VIP") sum=priceTicket * 300.40;
            }
            else if(stage=="Final")
            {
                if (typeTicket == "Standard") sum=priceTicket * 110.10;
                else if (typeTicket == "Premium") sum=priceTicket * 160.66;
                else if (typeTicket == "VIP") sum=priceTicket * 400.00;
            }
            if (sum>4000)
            {
                sum *= 0.75;
                wantPhot=false;
            }
            else if (sum>2500 )
            {
                sum *= 0.90;
            }
            if (wantPhot) sum += fotoWithoutTrophy * priceTicket;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
