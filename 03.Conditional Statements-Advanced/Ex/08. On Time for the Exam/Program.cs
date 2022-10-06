using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int hourExam=int.Parse(Console.ReadLine());
            int minuteExam=int.Parse(Console.ReadLine());
            int hourArrive=int.Parse(Console.ReadLine());
            int minutesArrive=int.Parse(Console.ReadLine());
            int time = hourExam * 60 + minuteExam;
            int arrive = hourArrive * 60 + minutesArrive;
            double arriveTotal = Math.Abs(arrive-time);
            double diffHour = arriveTotal / 60;
            double diffMin = arriveTotal % 60;
            if (time < arriveTotal)
            {
                Console.WriteLine("Late");
                if (diffHour>=1)
                {

                }
                
            }
            

        }
    }
}
