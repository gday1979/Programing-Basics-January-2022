using Microsoft.VisualBasic;
using System;

namespace _02._Football_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int win = 0;
            int draw = 0;
            int lose = 0;
            for (int i = 1; i <=3; i++)
            {
                string input= Console.ReadLine();
                int one = int.Parse(input[0].ToString());
                int two = int.Parse(input[2].ToString());
                if(one>two)win++;
                else if(one==two)draw++;
                else if(two>one)lose++;
            }
            Console.WriteLine($"Team won {win} games.");
            Console.WriteLine($"Team lost {lose} games.");
            Console.WriteLine($"Drawn games: {draw}");
        }
    }
}
