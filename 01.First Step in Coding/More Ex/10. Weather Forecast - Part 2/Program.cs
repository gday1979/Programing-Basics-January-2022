using System;

namespace _10._Weather_Forecast___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            if (degrees>=26 && degrees<=35)
            {
                Console.WriteLine("Hot");
            }
            else if (degrees>=20.10 && degrees <=25.90)
            {
                Console.WriteLine("Warm");
            }
            else if (degrees>=15 && degrees <=20.00)
            {
                Console.WriteLine("Mild");
            }
            else if (degrees>=12 && degrees <=14.90)
            {
                Console.WriteLine("Cool");
            }
            else if (degrees>=5 && degrees <=11.90)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
