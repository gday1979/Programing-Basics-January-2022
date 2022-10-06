using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heigh = int.Parse(Console.ReadLine());
            int widht = int.Parse(Console.ReadLine());
            int size=int.Parse(Console.ReadLine());
            int sumSize=heigh*widht*size;
            string input;
            while (sumSize>=0 && (input=Console.ReadLine()) !="Done")
            {
                sumSize-=int.Parse(input);
            }
            if (sumSize>=0)
            {
                Console.WriteLine($"{sumSize} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {-sumSize} Cubic meters more.");
            }
        }
    }
}
