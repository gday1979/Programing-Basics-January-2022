using System;

namespace _06._Flower_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double countMagnolia = double.Parse(Console.ReadLine());
            double countHyacinth=double.Parse(Console.ReadLine());
            double countRose=double.Parse(Console.ReadLine());
            double countCactus=double.Parse(Console.ReadLine());
            double sumGift=double.Parse(Console.ReadLine());
            double priceMagnolia = countMagnolia * 3.25;
            double priceHyacinth = countHyacinth * 4.00;
            double priceRose = countRose * 3.50;
            double priceCactus = countCactus * 8.00;
            double allSum = (priceMagnolia + priceHyacinth + priceRose + priceCactus) ;
            double sum = allSum - (allSum * 0.05);
            double totalSum = sumGift - sum;
            double needSum = sum - sumGift;
            if (sum>=sumGift)
            {
                Console.WriteLine($"She is left with {Math.Floor(-totalSum)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(-needSum)} leva.");
            }
        }
    }
}
