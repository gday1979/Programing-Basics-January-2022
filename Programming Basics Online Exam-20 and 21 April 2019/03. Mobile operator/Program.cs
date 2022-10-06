using System;

namespace _03._Mobile_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contract=Console.ReadLine();
            string typeContract=Console.ReadLine();
            string internet=Console.ReadLine();
            double months=double.Parse(Console.ReadLine());
            double allSum = 0;
            double priceInternet = 0;
            double priceTv = 0;

            if (contract == "one")
            {
                if (typeContract == "Small")
                {
                    priceTv = 9.98;
                    if (internet == "yes" && priceTv <= 10)
                    {
                        priceInternet = 5.50;
                        allSum = (priceTv + priceInternet) * months;
                    }
                    else
                    {
                        allSum = priceTv * months;
                    }
                }
                else if (typeContract == "Middle")
                {
                    priceTv = 18.99;
                    if (internet == "yes" && priceTv > 10 && priceTv <= 30)
                    {
                        priceInternet = 4.35;
                        allSum = (priceTv + priceInternet) * months;
                    }
                    else
                    {
                        allSum = priceTv * months;
                    }
                }
                else if (typeContract == "Large")
                {
                    priceTv = 25.98;
                    if (internet == "yes" && priceTv > 10 && priceTv <= 30)
                    {
                        priceInternet = 4.35;
                        allSum = (priceTv + priceInternet) * months;
                    }
                    else
                    {
                        allSum = priceTv * months;
                    }
                }
                else if (typeContract == "ExtraLarge")
                {
                    priceTv = 35.99;
                    if (internet == "yes" && priceTv > 30)
                    {
                        priceInternet = 4.35;
                        allSum = (priceTv + priceInternet) * months;
                    }
                    else
                    {
                        allSum = priceTv * months;
                    }
                }
            }
            else if (contract == "two")
            {
                if(typeContract == "Small")
                {
                    priceTv = 8.58;
                    if (internet == "yes" && priceTv <= 10)
                    {
                        priceInternet = 5.50;
                        allSum = (priceTv + priceInternet) * months;
                    }
                    else
                    {
                        allSum = priceTv * months;
                    }
                }
                else if (typeContract == "Middle")
                {
                    priceTv = 17.09;
                    if (internet == "yes" && priceTv > 10 && priceTv <= 30)
                    {
                        priceInternet = 4.35;
                        allSum = (priceTv + priceInternet) * months;
                    }
                    else
                    {
                        allSum = priceTv * months;
                    }
                }
                else if (typeContract == "Large")
                {
                    priceTv = 23.59;
                    if (internet == "yes" && priceTv > 10 && priceTv <= 30)
                    {
                        priceInternet = 4.35;
                        allSum = (priceTv + priceInternet) * months;
                    }
                    else
                    {
                        allSum = priceTv * months;
                    }
                }
                else if (typeContract == "ExtraLarge")
                {
                    priceTv = 31.79;
                    if (internet == "yes" && priceTv > 30)
                    {
                        priceInternet = 3.85;
                        allSum = (priceTv + priceInternet) * months;
                    }
                    else
                    {
                        allSum = priceTv * months;
                    }
                }
            }
            if (contract=="two")
            {
                allSum *= 0.9625;
            }
            Console.WriteLine($"{allSum:f2} lv.");
        }
    }
}
