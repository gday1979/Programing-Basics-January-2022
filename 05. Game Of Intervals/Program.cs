using System;

namespace _05._Game_Of_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double score = 0;
            double second = 0;
            double third = 0;
            double fourth = 0;
            double fifth = 0;
            double sixth = 0;
            double invalid = 0;

            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number >= 0 && number <= 9)
                {
                    second++;
                    score += number * 0.2;
                }
                else if (number >= 10 && number <= 19)
                {
                    third++;
                    score += number * 0.3;
                }
                else if (number >= 20 && number <= 29)
                {
                    fourth++;
                    score += number * 0.4;
                }
                else if (number >= 30 && number <= 39)
                {
                    fifth++;
                    score += 50;
                }
                else if (number >= 40 && number <= 50)
                {
                    sixth++;
                    score += 100;
                }

                else
                {
                    invalid++;
                    score = score / 2;
                }

            }
            double lowtotal = (second / n) * 100;
            double middletotal = (third / n) * 100;
            double avaragetotal = (fourth / n) * 100;
            double highttotal = (fifth / n) * 100;
            double abovetotal = (sixth / n) * 100;
            double invalidtotal = (invalid / n) * 100;

            Console.WriteLine($"{score:f2}");
            Console.WriteLine($"From 0 to 9: {lowtotal:f2}%");
            Console.WriteLine($"From 10 to 19: {middletotal:f2}%");
            Console.WriteLine($"From 20 to 29: {avaragetotal:f2}%");
            Console.WriteLine($"From 30 to 39: {highttotal:f2}%");
            Console.WriteLine($"From 40 to 50: {abovetotal:f2}%");
            Console.WriteLine($"Invalid numbers: {invalidtotal:f2}%");

        }
    }
}
