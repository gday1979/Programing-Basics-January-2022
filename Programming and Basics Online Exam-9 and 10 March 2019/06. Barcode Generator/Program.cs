using System;
using System.Runtime.ExceptionServices;

namespace _06._Barcode_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string one=Console.ReadLine();
            string two=Console.ReadLine();
            int w1 = int.Parse(one[0].ToString());
            int w2 = int.Parse(one[1].ToString());
            int w3 = int.Parse(one[2].ToString());
            int w4 = int.Parse(one[3].ToString());
            int z1 = int.Parse(two[0].ToString());
            int z2 = int.Parse(two[1].ToString());
            int z3 = int.Parse(two[2].ToString());
            int z4 = int.Parse(two[3].ToString());
            for (int i = w1; i <= z1; i++)
            {
                for (int i2 = w2; i2 <= z2; i2++)
                {
                    for (int i3 = w3; i3 <= z3; i3++)
                    {
                        for (int i4 = w4; i4 <= z4; i4++)
                        {
                            if (i %2 !=0 && i2 % 2 !=0  && i3 % 2 !=0 && i4 %2 !=0)
                            {
                                Console.Write($"{i}{i2}{i3}{i4} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
