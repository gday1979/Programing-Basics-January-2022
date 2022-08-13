using System;

namespace _06._Number_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers=int.Parse(Console.ReadLine());
            if (numbers>=-100 && numbers <=100 && numbers !=0)
            {
                Console.WriteLine("Yes");
            }
            else 
            {
                Console.WriteLine("No");
            }
        }
    }
}
