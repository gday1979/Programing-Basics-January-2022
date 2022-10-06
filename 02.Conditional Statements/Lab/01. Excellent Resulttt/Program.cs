using System;

namespace _01._Excellent_Resulttt
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double assessment=double.Parse(Console.ReadLine());
            if (assessment>=5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else if (assessment<5.50 )
            {
                Console.WriteLine();
            }

        }
    }
}
