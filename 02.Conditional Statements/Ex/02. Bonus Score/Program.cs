using System;

namespace _02._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers=int.Parse(Console.ReadLine());
            double bonusPoints=0.0;
            
            if (numbers <=100)
            {
                bonusPoints = 5;

            }
            else if (numbers >100 && numbers <1000)
            {
                bonusPoints = numbers * 0.2;
            }
            else if (numbers >1000)
            {
                bonusPoints = numbers * 0.1;
            }
            if (numbers %2==0)
            {
                bonusPoints = bonusPoints + 1;
            }
            else if (numbers %10==5)
            {
                bonusPoints += 2;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(numbers+bonusPoints);
        }
    }
}
