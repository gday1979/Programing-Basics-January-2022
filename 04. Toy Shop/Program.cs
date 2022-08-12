using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double trip = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine()); 
            int mignon=int.Parse(Console.ReadLine());
            int truck=int.Parse(Console.ReadLine());
            int sumOfNumbers=puzzle+doll+bears+mignon+truck;
            double pricePuzzle = puzzle * 2.60;
            double priceDolls = doll * 3;
            double priceBears = bears * 4.10;
            double priceMignon = mignon * 8.20;
            double priceTrucks = truck * 2;
            double sum=pricePuzzle + priceDolls + priceBears + priceMignon + priceTrucks;
            
            if (sumOfNumbers >50)
            {
                sum =(pricePuzzle+priceDolls+priceBears+priceMignon+priceTrucks)-(25/100.0*(pricePuzzle+priceDolls+priceBears+priceMignon+priceTrucks));
            }
            double rent = sum * 0.10;
            double allSum = sum - rent;
         
            if (allSum>=trip)
            {
                double moneyLeft = allSum - trip;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                double moneyLeft = trip - allSum;
                Console.WriteLine($"Not enough money! {moneyLeft:f2} lv needed.");
            }
        }
    }
}
