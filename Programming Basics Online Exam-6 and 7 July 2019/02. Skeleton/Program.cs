using System;

namespace _02._Skeleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutes=int.Parse(Console.ReadLine());
            double seconds=double.Parse(Console.ReadLine());
            double lenght=double.Parse(Console.ReadLine());
            double secondsPerMeters=double.Parse(Console.ReadLine());
             int minutesPer=minutes*60;
            double lenghtPer =lenght/ 120;
            double lenghtTime = lenghtPer * 2.5;
            double controlTime = minutesPer + seconds;
            double timePlayer = (lenght / 100) * secondsPerMeters - lenghtTime;
            if (timePlayer<=controlTime)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {timePlayer:f3}.");
            }
           
            else
            {
                double needTime = controlTime - timePlayer;
                Console.WriteLine($"No, Marin failed! He was {-needTime:f3} second slower.");
            }
        }
    }
}
