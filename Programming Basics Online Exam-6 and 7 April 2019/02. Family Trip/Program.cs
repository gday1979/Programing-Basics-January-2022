using System;

namespace _02._Family_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bydget=double.Parse(Console.ReadLine());
            double nights=double.Parse(Console.ReadLine());
            double moneyForNights=double.Parse(Console.ReadLine());
            double procent=double.Parse(Console.ReadLine());
            double sum = 0;
            
            if (nights>7)
            {
                moneyForNights *= 0.95;
                sum=moneyForNights*nights;
            }
            else
            {
                sum=nights*moneyForNights;
            }
            double sumprocent = bydget * procent/100;
            double all = sum + sumprocent;
            double total = bydget - all;
            if (total>=0)
            {
                Console.WriteLine($"Ivanovi will be left with {total:f2} leva after vacation.");
            }
            
            else if(total<0)
            {
                Console.WriteLine($"{-total:f2} leva needed.");

            }
            
        }
    }
}
