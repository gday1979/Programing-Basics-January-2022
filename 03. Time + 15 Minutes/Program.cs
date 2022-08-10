using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hour = double.Parse(Console.ReadLine());
            double minute = double.Parse(Console.ReadLine());
            double hourInMin = minute + 15; ;
            if (hourInMin >=60)
            {
                hour++;
                hourInMin-=60;
            }
            if (hour >=24)
            {
                hour = 0;
            }
            if (hourInMin<10)
            {
                Console.WriteLine($"{hour}:0{hourInMin}");
            }
            else
            {
                Console.WriteLine($"{hour}:{hourInMin}");
            }
           
        }
    }
}
