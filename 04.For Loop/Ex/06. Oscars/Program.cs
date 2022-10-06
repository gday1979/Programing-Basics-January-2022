using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double total = points;
            bool flag=false;
            for (int i = 0; i < n; i++)
            {
                string judge = Console.ReadLine();
                double pointsJudge = double.Parse(Console.ReadLine());
                double momentPoints = (judge.Length * pointsJudge) / 2;
                total = total + momentPoints;


                if (total >= 1250.5)
                {
                    flag = true;
                    break;

                }
            }
            if (flag)
            {


                Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {total:f1}!");
            }

            
            else
            {
                Console.WriteLine($"Sorry, {actor} you need {1250.5-total:f1} more!");
            }
        }
    }
}
