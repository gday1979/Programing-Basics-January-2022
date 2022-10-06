using System;

namespace _03._Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cargoQuantity=int.Parse(Console.ReadLine());
            double price = 0;
            double sumBus = 0;
            double sumTuck = 0;
            double sumTrain = 0;
            int countBus = 0;
            int countTruck = 0;
            int countTrain = 0;
            for (int i = 1; i <= cargoQuantity; i++)
            {
                int cargo = int.Parse(Console.ReadLine());
                if (cargo <=3)
                {
                    sumBus += cargo*200;
                    countBus += cargo;
                }
                else if (cargo>=4 && cargo<=11)
                { 
                    sumTuck += cargo * 175;
                    countTruck += cargo;
                }
                else if (cargo>=12)
                {
                    sumTrain += cargo * 120;
                    countTrain += cargo;
                }
            }
            double totalTons=countBus+countTruck+countTrain;
            price = sumBus + sumTrain + sumTuck;
            double average=price/totalTons;
            double procentBus = countBus / totalTons * 100;
            double procentTuck = countTruck / totalTons * 100;
            double procentTrain=countTrain/ totalTons * 100;
            Console.WriteLine($"{average:f2}");
            Console.WriteLine($"{procentBus:f2}%");
            Console.WriteLine($"{procentTuck:f2}%");
            Console.WriteLine($"{procentTrain:f2}%");
        }
    }
}
