using System;

namespace _06._Name_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int charLetter = 0;
            int MaxScore = 0;
            string WinnerName = string.Empty; // същото е като string = ""; но е по ...прилежно

            while (name != "Stop")
            {
                int currentScore = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    charLetter = (int)name[i];

                    int n = int.Parse(Console.ReadLine()); // тук четем число, а не в самото начало, за да отговаря на всяка буква!

                    if (charLetter == n)
                    {
                        currentScore = currentScore + 10;
                    }
                    else
                    {
                        currentScore = currentScore + 2;
                    }

                    if (currentScore >= MaxScore) // >= брез равно дава 90/100
                    {
                        MaxScore = currentScore;
                        WinnerName = name;
                    }
                }

                name = (Console.ReadLine());
            }

            Console.WriteLine("The winner is {0} with {1} points!", WinnerName, MaxScore);
        }
    }
}
