using System;

namespace _04._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students=int.Parse(Console.ReadLine());
            double sumTop = 0;
            double sum4to5=0;
            double sum3to4 = 0;
            double fail = 0;
            double countTop = 0;
            double count4to5=0;
            double count3to4 = 0;
            double countFail = 0;

            for (int i = 1; i <=students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade>=5)
                {
                    sumTop += grade;
                    countTop++;
                }
                else if (grade>=4 && grade <=4.99)
                {
                    sum4to5+=grade;
                    count4to5++;
                }
                else if (grade>=3 && grade <=3.99)
                {
                    sum3to4 += grade;
                    count3to4++;
                }
                else if (grade<3)
                {
                    fail += grade;
                    countFail++;
                }
            }
            double countTotal = countTop + count4to5 + count3to4 + countFail;
            double allSum = sumTop + sum4to5 + sum3to4 + fail;
            double average=allSum/students;
            double topProcent = countTop / countTotal*100;
            double fifthProcent = count4to5 / countTotal * 100;
            double thirdRocent=count3to4/countTotal*100;
            double failProcent=countFail/countTotal*100;
            Console.WriteLine($"Top students: {topProcent:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {fifthProcent:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {thirdRocent:f2}%");
            Console.WriteLine($"Fail: {failProcent:f2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
