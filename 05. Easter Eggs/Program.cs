using System;

namespace _05._Easter_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
           
            int countOrange = 0;
            int countRed = 0;
            int countBlue = 0;
            int countGreen = 0;
           
            for (int i = 0; i < count; i++)
            {
                string typeOfColor = Console.ReadLine();
                if (typeOfColor == "red")
                {
                    countRed++;
                    
                }
                else if (typeOfColor == "blue")
                {
                    countBlue++;
                   
                }
                else if (typeOfColor == "orange")
                {
                    countOrange++;
                    
                }
                else if (typeOfColor == "green")
                {
                    countGreen++;
                    
                }
            }

            Console.WriteLine($"Red eggs: {countRed}");
            Console.WriteLine($"Orange eggs: {countOrange}");
            Console.WriteLine($"Blue eggs: {countBlue}");
            Console.WriteLine($"Green eggs: {countGreen}");
            
            int max = Math.Max(Math.Max(countRed, countOrange), Math.Max(countBlue, countGreen));
            Console.Write($"Max eggs: {max} -> ");
            if (max == countRed) Console.WriteLine("red");
            else if (max == countOrange) Console.WriteLine("orange");
            else if (max == countBlue) Console.WriteLine("blue");
            else if (max == countGreen) Console.WriteLine("green");
        }
    }
}
