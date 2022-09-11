using System;
using System.Runtime.InteropServices;

namespace _12._The_song_of_the_wheels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int controlNumber=int.Parse(Console.ReadLine());
            int counter = 0;
            int password = 0;
            bool forthNum=false;
            for (int a = 1; a <=9; a++)
            {
                for (int b = 1; b <=9; b++)
                {
                    for (int c = 1; c <=9; c++)
                    {
                        for (int d = 1; d <=9; d++)
                        {
                            int needNum = (a * b) + (c * d);
                            if (a<b && c>d && (needNum==controlNumber))
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                                counter++;
                                if (counter==4)
                                {
                                    password = 1000 * a + 100 * b + 10 * c + d;
                                    forthNum = true;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            if (forthNum==true)
            {
                Console.WriteLine("Password: {0}" , password);
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}
