using System;

namespace _07._Football_League
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double capacity=double.Parse(Console.ReadLine());
            double allFans=double.Parse(Console.ReadLine());
            
            double coubterA = 0;
            double coubterB = 0;
            double counterV=0;
            double counterG = 0;
            for (int i = 0; i < allFans; i++)
            {
                string allText=Console.ReadLine();
                if (allText=="A")
                {
                    coubterA++;
                }
                else if (allText=="B")
                {
                    coubterB++;
                }
                else if (allText=="V")
                {
                    counterV++;
                }
                else if (allText=="G")
                {
                    counterG++;
                }
            }
            double average = allFans / capacity * 100;
            Console.WriteLine($"{coubterA/allFans*100:f2}%");
            Console.WriteLine($"{coubterB/allFans*100:f2}%");
            Console.WriteLine($"{counterV/allFans*100:f2}%");
            Console.WriteLine($"{counterG/allFans*100:f2}%");
            Console.WriteLine($"{allFans/capacity*100:f2}%");
        }
    }
}
