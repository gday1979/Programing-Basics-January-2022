using System;

namespace _04._Game_Number_Wars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerOne = Console.ReadLine();
            string playerTwo = Console.ReadLine();
            string input = Console.ReadLine();
            int pointOne = 0;
            int pointTwo = 0;
            bool numberWarsOn = false;

            while (input != "End of game")
            {
                int cardOne = int.Parse(input);
                int cardTwo = int.Parse(Console.ReadLine());
                if (cardOne > cardTwo)
                {

                    pointOne += cardOne-cardTwo;
                }
                else if (cardTwo > cardOne)
                {
                    
                    pointTwo += cardTwo-cardOne;

                }
                else
                {

                    numberWarsOn = true;
                    Console.WriteLine("Number wars!");
                    cardOne = int.Parse(Console.ReadLine());
                    cardTwo = int.Parse(Console.ReadLine());
                    if (cardOne > cardTwo) Console.WriteLine($"{playerOne} is winner with {pointOne} points");
                    else Console.WriteLine($"{playerTwo} is winner with {pointTwo} points");
                    break;
                }
                input = Console.ReadLine();
            }
            if (!numberWarsOn)
            {


                Console.WriteLine($"{playerOne} has {pointOne} points");
                Console.WriteLine($"{playerTwo} has {pointTwo} points");
            }

        }
    }
}

