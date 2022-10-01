using System;

namespace _01._Change_Bureau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bitcoin =double.Parse(Console.ReadLine());
            double juan=double.Parse(Console.ReadLine());
            double comision=double.Parse(Console.ReadLine());
            double priceBitcoin = bitcoin * 1168;
            double priceUsd = 1.76;
            double priceJuan = (juan*0.15)*priceUsd;
            double euro = 1.95;
            double allSum = (priceBitcoin + priceJuan) / euro;
            double sum=allSum-(allSum*comision/100);
            Console.WriteLine($"{sum:f2}");
        }
    }
}
