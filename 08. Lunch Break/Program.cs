using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double epizod=double.Parse(Console.ReadLine()); 
            double time=double.Parse(Console.ReadLine());
            double timeLunch = time*5.0 / 8;
            
            if (timeLunch>=epizod)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(timeLunch-epizod)} minutes free time.");
            }
            else 
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(epizod - timeLunch)} more minutes.");
            }

        }
    }
}
