using System;

namespace _02._Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double degrees = radius * 180 / Math.PI;
            Console.WriteLine(degrees);
        }
    }
}
