using System;

namespace _05._Football_Tournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string team=Console.ReadLine();
            double playedGames=double.Parse(Console.ReadLine());
            
            
            double countWins = 0;
            double countDraws = 0;
            double countLose = 0;
            double total = 0;
            for (double i = 0; i < playedGames; i++)
            {
                string command = Console.ReadLine();
                if ( command== "W")
                {
                    total += 3;
                    countWins++;
                }
                else if (command=="D")
                {
                    total += 1;
                    countDraws++;
                }
                else if (command=="L")
                {
                    total += 0;
                    countLose++;
                }
            }
            if (playedGames<= 0)
            {
                Console.WriteLine($"{team} hasn't played any games during this season.");
            }
            else
            {
                Console.WriteLine($"{team} has won {total} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {countWins}");
                Console.WriteLine($"## D: {countDraws}");
                Console.WriteLine($"## L: {countLose}");
                Console.WriteLine($"Win rate: {countWins/playedGames*100:f2}%");
            }
            
        }
    }
}
