using System;

namespace _03._Painting_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type=Console.ReadLine();
            string color=Console.ReadLine();
            double quantity=double.Parse(Console.ReadLine());
            double sum = 0;
            if (type=="Large")
            {
                if (color=="Red")
                {
                    sum = quantity * 16;
                }
                else if (color=="Green")
                {
                    sum = quantity * 12;
                }
                else if (color=="Yellow")
                {
                    sum = quantity * 9;
                }
            }
            else if (type=="Medium")
            {
                if (color == "Red")
                {
                    sum = quantity * 13;
                }
                else if (color == "Green")
                {
                    sum = quantity * 9;
                }
                else if (color == "Yellow")
                {
                    sum = quantity * 7;
                }
            }
            else if (type=="Small")
            {
                if (color == "Red")
                {
                    sum = quantity * 9;
                }
                else if (color == "Green")
                {
                    sum = quantity * 8;
                }
                else if (color == "Yellow")
                {
                    sum = quantity * 5;
                }
            }
            double allSum = sum * 0.65;
            Console.WriteLine($"{allSum:f2} leva.");
        }
    }
}
