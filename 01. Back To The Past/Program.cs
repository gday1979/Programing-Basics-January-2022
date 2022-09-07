using System;

namespace _01._Back_To_The_Past
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum=double.Parse(Console.ReadLine());
            int yearHeLive=int.Parse(Console.ReadLine());
            double spend = 12000;
            double yearIvan = 18;
            double total1 = 0;
            double total2 = 0;
            for (int i = 1800; i <= yearHeLive; i++)
            {

                if (i%2==0)
                {
                    total1 = total1+ spend;
                }
                else
                {
                    total2 =total2+(spend +(yearIvan * 50));
                }
                yearIvan++;
            }
            double final = sum - (total1 + total2);
            if (final>=0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {final:F2} dollars left.");
            }
            else 
            {
                
                Console.WriteLine($"He will need {-final:f2} dollars to survive.");
            }
        }
    }
}
