using System;

namespace _13._Prime_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int num1To = int.Parse(Console.ReadLine());
            int num2To = int.Parse(Console.ReadLine());

            for (int n = num1; n <= num1 + num1To; n++)
            {
                for (int m = num2; m <= num2 + num2To; m++)
                {
                    bool isNPrime = true;
                    bool isMPrime = true;

                    for (int i = 2; i <= Math.Sqrt(n); i++)
                    {
                        if (n % i == 0)
                        {
                            isNPrime = false;
                            break;
                        }
                    }
                    for (int j = 2; j <= Math.Sqrt(m); j++)
                    {
                        if (m % j == 0)
                        {
                            isMPrime = false;
                            break;
                        }
                    }

                    if (isNPrime && isMPrime)
                    {
                        Console.WriteLine($"{n}{m}");
                    }
                }
            }
        }
    }
}
