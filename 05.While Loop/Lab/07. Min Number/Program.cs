using System;

namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallNumber = int.MaxValue;
            string input=Console.ReadLine();
            while (input !="Stop")
            {
                int number = int.Parse(input);
                if (number<smallNumber)
                {
                    smallNumber = number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(smallNumber);
        }
    }
}
