using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            int bigestNumber = int.MinValue;
            while (input !="Stop")
            {
                int number=int.Parse(input);
                if (number>bigestNumber)
                {
                   bigestNumber= number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(bigestNumber);
        }
    }
}
