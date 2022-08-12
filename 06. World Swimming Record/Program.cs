using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordSeconds=double.Parse(Console.ReadLine());
            double meters=double.Parse(Console.ReadLine());
            double timeInSeconds=double.Parse(Console.ReadLine());
            double swiming = meters * timeInSeconds;
            double delay = Math.Floor((meters / 15)) * 12.5;
            double alltime = swiming + delay;
            double worldRecord = 0.00;
            
                
            if (alltime<recordSeconds)
            {
                
                Console.WriteLine($"Yes, he succeeded! The new world record is {alltime:f2} seconds.");
            }
            else 
            {
                worldRecord = alltime-recordSeconds;
                Console.WriteLine($"No, he failed! He was {worldRecord:f2} seconds slower.");
            }
        }
    }
}
