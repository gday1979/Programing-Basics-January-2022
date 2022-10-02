using System;
using System.Threading.Tasks;

namespace _04._Easter_Eggs_Battle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerOne=int.Parse(Console.ReadLine());
            int playerTwo=int.Parse(Console.ReadLine());
            string command=Console.ReadLine();
            while (command!="End")
            {
               
                if (command=="one")
                {
                    playerTwo--;
                }
                else if (command=="two")
                {
                    playerOne--;
                }
                if (playerOne == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {playerTwo} eggs left.");
                    break;
                }
                else if (playerTwo == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {playerOne} eggs left.");
                    break;
                }
                command =Console.ReadLine();
            }
            
            if (command == "End")
            {
                Console.WriteLine($"Player one has {playerOne} eggs left.");
                Console.WriteLine($"Player two has {playerTwo} eggs left.");
            }
           
        }
    }
}
