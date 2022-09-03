using System;

namespace _02._Triangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double hight=double.Parse(Console.ReadLine());
            double result = side * hight / 2;
            Console.WriteLine($"{result:f2}");
        }
    }
}
