using System;

namespace _06._Easter_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int easterBread = int.Parse(Console.ReadLine());
            string winer = "";
            int winnerBaker = 0;
            int baker = 0;
            for (int i = 0; i < easterBread; i++)
            {
                string chef = Console.ReadLine();
                string command=Console.ReadLine();  
                while (command!="Stop")
                {
                    int deilyEvaluation=int.Parse(command);
                    baker += deilyEvaluation;
                    command=Console.ReadLine();
                }
                
                Console.WriteLine($"{chef} has {baker} points.");
                
                if (baker > winnerBaker)
                {
                    winnerBaker = baker;
                    winer=chef;
                    Console.WriteLine($"{chef} is the new number 1!");
                }
                baker = 0;
            }
            Console.WriteLine($"{winer} won competition with {winnerBaker} points!");

        }
    }
}
