using System;

namespace _03._Aluminum_Joinery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double joinery=double.Parse(Console.ReadLine());
            string type=Console.ReadLine();
            string deliveryType=Console.ReadLine();
            double sum = 0;
            if (joinery < 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }
            switch (type)
            {
                case "90X130":
                    sum += joinery * 110;
                    if (joinery>60)
                    {
                        sum *= 0.92;
                    }
                    else if (joinery>30)
                    {
                        sum *= 0.95;
                    }
                    break;
                case "100X150":
                    sum += joinery * 140;
                    if (joinery>80)
                    {
                        sum *= 0.90;
                    }
                    else if (joinery>40)
                    {
                        sum *= 0.94;
                    }
                    break;
                case "130X180":
                    sum += joinery * 190;
                    if (joinery>50)
                    {
                        sum *= 0.88;
                    }
                    else if (joinery>20)
                    {
                        sum *= 0.93;
                    }
                    break ;
                case "200X300":
                    sum += joinery * 250;
                    if (joinery>50)
                    {
                        sum *= 0.88;
                    }
                    else if (joinery>25)
                    {
                        sum *= 0.91;
                    }
                    break;
            }
            
            if (deliveryType=="With delivery")
            {
                sum += 60;
            }
            else if (deliveryType=="Without delivery")
            {
                sum *= 1;
            }
            if (joinery > 100)
            {
                sum *= 0.96;
            }
            Console.WriteLine($"{sum:f2} BGN");
        }
    }
}
