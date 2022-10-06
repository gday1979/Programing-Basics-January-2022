using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hight = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int sizeCake = hight * width;
            string pieces;

            while (sizeCake >= 0 && (pieces = Console.ReadLine()) != "STOP")
            {
                sizeCake -= int.Parse(pieces);
            }


            if (sizeCake>=0)
            {
                Console.WriteLine($"{sizeCake} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {-sizeCake} pieces more.");
            }

        }
    }
}
