using System;

namespace _02._Movie_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double photos = double.Parse(Console.ReadLine());
            double scene=double.Parse(Console.ReadLine());
            double time=double.Parse(Console.ReadLine());
            double timeForPhotos = photos * 0.15;
            double timeFortake = scene * time;
            double sum=timeForPhotos+timeFortake;
            if (photos>sum)
            {
                double leftOver = photos - sum;
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(leftOver)} minutes left!");
            }
            else
            {
                double needTime = sum - photos;
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(needTime)} minutes.");
            }

        }
    }
}
