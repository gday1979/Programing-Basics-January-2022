using System;

namespace _06._Basketball_Tournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tornament=Console.ReadLine();
            
            
            double countWins = 0;
            double countLose = 0;
            double countAllMatches=0;
            while (tornament!="End of tournaments")
            {
               
                int matches=int.Parse(Console.ReadLine());
                int countMatches = 0;
                for (int i = 0; i < matches; i++)
                {
                    int desyTeamPoints =int.Parse(Console.ReadLine());
                    int otherTeamPoints = int.Parse(Console.ReadLine());
                    int diferencePoints=desyTeamPoints - otherTeamPoints;
                    countAllMatches++;
                    countMatches++;
                    if (desyTeamPoints>otherTeamPoints)
                    {
                        
                        Console.WriteLine($"Game {countMatches} of tournament {tornament}: win with {diferencePoints} points.");
                        countWins++;
                    }
                    else
                    {
                        Console.WriteLine($"Game {countMatches} of tournament {tornament}: lost with {-diferencePoints} points.");
                        countLose++;

                    }
                }
                
                tornament = Console.ReadLine();
            }

            Console.WriteLine($"{countWins / countAllMatches * 100:f2}% matches win");
            Console.WriteLine($"{countLose / countAllMatches * 100:f2}% matches lost");

        }
    }
}
