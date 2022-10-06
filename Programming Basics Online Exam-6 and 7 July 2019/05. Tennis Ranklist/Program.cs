using System;

namespace _05._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            double startPoints = double.Parse(Console.ReadLine());
            double win = 2000;
            double final = 1200;
            double semiFinal = 720;
            double winCount = 0;
            double sum=0;
            double points = 0;
            for (int i = 0; i < tournaments; i++)
            {
                string typeOfStandings = Console.ReadLine();
                switch (typeOfStandings)
                {
                    case "W":
                        sum += win;
                        winCount++;
                        break;
                    case "F":
                          sum+=final;
                        break;
                    case "SF":
                       sum+= semiFinal;
                        break;
                }
                points = startPoints + sum;
            }
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor(sum / tournaments)}");
            Console.WriteLine($"{winCount/tournaments*100:f2}%");
        }
    }
}
