using System;

namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type=Console.ReadLine();
            
            if (type=="square")
            {
                double sizeType=double.Parse(Console.ReadLine());
                double result = sizeType * sizeType;
                Console.WriteLine($"{result:f3}");
            }
            else if (type=="rectangle")
            {
                double oneSide=double.Parse(Console.ReadLine());
                double secondSide=double.Parse(Console.ReadLine()); 
                double result=oneSide*secondSide;
                Console.WriteLine($"{result:f3}");
            }
            else if (type=="circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double result = Math.PI * radius * radius;
                Console.WriteLine($"{result:f3}");
            }
            else if (type=="triangle")
            {
                double oneSide = double.Parse(Console.ReadLine());
                double secondSide = double.Parse(Console.ReadLine());
                double result = oneSide * secondSide / 2;
                Console.WriteLine($"{result:f3}");
            }
        }
    }
}
