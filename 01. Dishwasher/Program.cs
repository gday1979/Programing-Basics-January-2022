using System;

namespace _01._Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int botle=int.Parse(Console.ReadLine());
            botle *= 750;
           
            string numberOfContainers = "";
            int counter=0;
            int containers = 0;
            int numbersOfDish = 0;
            int numberOfPot = 0;
            while (true)
            {
                    numberOfContainers = Console.ReadLine();
                if (numberOfContainers=="End")
                {
                    break;
                }
                counter++;
                if (counter %3==0)
                {
                    containers = int.Parse(numberOfContainers);
                    numberOfPot+=containers;
                    botle -= containers * 15;
                }
                else
                {
                    containers = int.Parse(numberOfContainers);
                    numbersOfDish += containers;
                    botle -= containers * 5;
                }
                if (botle < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(botle)} ml. more necessary!");
                    return;
                }
                

            }
            Console.WriteLine($"Detergent was enough!");
            Console.WriteLine($"{numbersOfDish} dishes and {numberOfPot} pots were washed.");
            Console.WriteLine($"Leftover detergent {botle} ml.");
        }
    }
}
