using System;

namespace _02._Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vacantionDays = int.Parse(Console.ReadLine());
            int vacantionsPlays = vacantionDays * 127;
            int year = 365;
            int daysPlays = (year - vacantionDays) * 63;
            int totalTime = vacantionsPlays + daysPlays;
            int neededTime = 30000;
            int restTime = neededTime - totalTime;
            int hourTime = Math.Abs(neededTime - totalTime) / 60;
            int minuteTime = Math.Abs(neededTime - totalTime) % 60;
            if (totalTime>=neededTime)
            {
                Console.WriteLine($"Tom will run away");
                Console.WriteLine($"{hourTime} hours and {minuteTime} minutes more for play");
            }
            else 
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hourTime} hours and {minuteTime} minutes less for play");
            }

        }
    }
}

