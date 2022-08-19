using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups=int.Parse(Console.ReadLine());
            int g1 = 0;
            int g2 = 0;
            int g3 = 0;
            int g4 = 0;
            int g5 = 0;
          
            for (int i = 1; i <=numberOfGroups; i++)
            {
                int cliffhanger = int.Parse(Console.ReadLine());
                if (cliffhanger<6)
                {
                    g1 += cliffhanger;
                }
                else if (cliffhanger<13)
                {
                    g2 +=cliffhanger;
                }
                else if (cliffhanger<26)
                {
                    g3 += cliffhanger;

                }
                else if ( cliffhanger<41)
                {
                    g4 += cliffhanger;
                }
                else 
                {
                    g5 += cliffhanger;
              
                }
                
            }
            int totalGroups = g1 + g2 + g3 + g4 + g5;
            Console.WriteLine($"{1.0*g1/totalGroups*100:f2}%");
            Console.WriteLine($"{1.0*g2/totalGroups*100:f2}%");
            Console.WriteLine($"{1.0*g3/totalGroups*100:f2}%");
            Console.WriteLine($"{1.0*g4/totalGroups*100:f2}%");
            Console.WriteLine($"{1.0*g5/totalGroups*100:f2}%");


        }
    }
}
