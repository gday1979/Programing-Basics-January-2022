using System;

namespace _10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  numbers=int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i < numbers; i++)
            {
                int number=int.Parse(Console.ReadLine());   
                if (i %2==0)
                {
                    evenSum += number;

                }
                else if (i%2 !=0)
                {
                    oddSum += number;
                }
            }
            if (evenSum==oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else if (evenSum !=oddSum)
            {
                int sumFinal=Math.Abs(oddSum-evenSum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {sumFinal}");
            }
        }
    }
}
