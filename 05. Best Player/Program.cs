using System;

namespace _05._Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            int goals = -1;
            string bestPlayer = "";
            while (input!="END")
            {
                int scoredGoals=int.Parse(Console.ReadLine());
                if (scoredGoals>goals)
                {
                    goals=scoredGoals;
                    bestPlayer = input;
                }
                if (goals>=10)
                {
                    break;
                }
                
                input=Console.ReadLine();
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if (goals>=3)
            {
                Console.WriteLine($"He has scored {goals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {goals} goals.");
            }
        }
    }
}
