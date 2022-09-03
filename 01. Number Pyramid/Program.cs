using System;

namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int curentNum = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(curentNum + " ");
                    curentNum++;
                    if (curentNum > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();

                if (curentNum > n)
                {
                    break;
                }
            }
        }
    }
}
