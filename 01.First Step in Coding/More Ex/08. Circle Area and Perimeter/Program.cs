using System;

namespace _08._Circle_Area_and_Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double r=double.Parse(Console.ReadLine());
            double area=Math.PI*(r*r);
            double parameter = ((2 * Math.PI) * r);
            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{parameter:f2}");
        }
    }
}
