using System;

namespace _03._Coffee_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeCofee=Console.ReadLine();
            string typeSugar=Console.ReadLine();
            double drinks=double.Parse(Console.ReadLine()); 
            double sum = 0;
            if (typeCofee=="Espresso")
            {
                switch (typeSugar)
                {
                    case "Without":
                        sum =drinks*0.90;
                        break;
                    case "Normal":
                        sum = drinks * 1; ;
                        break;
                    case "Extra":
                        sum =drinks*1.20;
                        break;
                }              
            }
            else if (typeCofee=="Cappuccino")
            {
                switch (typeSugar)
                {
                    case "Without":
                        sum = drinks * 1;
                break;
                    case "Normal":
                        sum = drinks * 1.20; 
                break;
                    case "Extra":
                        sum = drinks * 1.60;
                break;
                }
            }
            else if (typeCofee=="Tea")
            {
                switch (typeSugar)
                {
                    case "Without":
                        sum = drinks * 0.50;
                        break;
                    case "Normal":
                        sum = drinks * 0.60;
                        break;
                    case "Extra":
                        sum = drinks * 0.70;
                        break;
                }
            }
            if (typeSugar=="Without")
            {
                sum = sum - (sum * 0.35);
            }
            if (typeCofee=="Espresso" && drinks>5)
            {
                sum = sum - (sum * 0.25);
            }
            if (sum>15)
            {
                sum = sum - (sum * 0.20);
            }
            Console.WriteLine($"You bought {drinks} cups of {typeCofee} for {sum:f2} lv.");
        }
    }
}
