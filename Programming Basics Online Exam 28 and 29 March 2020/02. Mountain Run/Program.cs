using System;

namespace _02._Mountain_Run
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordSeconds=double.Parse(Console.ReadLine());
            double distance=double.Parse(Console.ReadLine());
            double timeInSeconds=double.Parse(Console.ReadLine());
            double time = distance * timeInSeconds;
            double delay = (Math.Floor(distance / 50) * 30);
            double alltime=time+delay;
            double newRecord = alltime - recordSeconds;
            
            if (recordSeconds>alltime)
            {
                Console.WriteLine($"Yes! The new record is {alltime:f2} seconds. ");
            }
            else
            {
                double needTime = recordSeconds - alltime;
                Console.WriteLine($"No! He was {-needTime:f2} seconds slower.");
            }
        }
    }
}
