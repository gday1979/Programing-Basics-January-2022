using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();
            
            double sumGrade = 0;
            int counter = 1;

            for (int grade = 1; grade <= 12; grade++)
            {


                double yearGrade = double.Parse(Console.ReadLine());
                if (yearGrade<4)
                {
                    counter++;
                    if (counter==2)
                    {
                        Console.WriteLine($" {name} has been excluded at {grade} grade");
                        break;
                    }
                    continue;
                }
                sumGrade +=yearGrade;
               

            }
            double averageGrade = sumGrade / 12;
            if (counter <2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
