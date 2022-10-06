using System;

namespace _03._Celsius_to_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double result = celsius * 1.8 + 32;
            Console.WriteLine($"{result:f2}");
        }
    }
}
