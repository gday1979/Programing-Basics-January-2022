using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int failedThreshold=int.Parse(Console.ReadLine());
           
            int failedTimes = 0;
            int solvedProblemCount = 0;
            double gradeSum = 0;
            string lastProblem= "";
            bool isFailed=true;
            while (failedTimes<failedThreshold)
            {
                string taskProblem=Console.ReadLine();
                if ("Enough" ==taskProblem)
                {
                    isFailed = false;
                    break;
                }
                int grade=int.Parse(Console.ReadLine());
                if (grade <=4)
                {
                    failedTimes++;
                }
                gradeSum+=grade;
                solvedProblemCount++;
                lastProblem = taskProblem;

            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedThreshold} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradeSum /solvedProblemCount:f2}");
                Console.WriteLine($"Number of problems: {solvedProblemCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
