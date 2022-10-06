using System;

namespace _04._Movie_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string actor ="";
            double sumActor = 0;
            while ((actor=Console.ReadLine()) !="ACTION")
            {
                
                if (actor.Length<=15 && actor.Length>0)
                {
                    double salary=double.Parse(Console.ReadLine());
                    sumActor= salary;
                }
                else
                {
                    sumActor = budget * 0.20;
                }
                if (budget<sumActor)
                {
                    break;
                }
                budget-=sumActor;
            }
            if (budget<sumActor)
            {
                Console.WriteLine($"We need {(sumActor - budget):f2} leva for our actors.");
            }
            else
            {
               
                Console.WriteLine($"We are left with {budget:f2} leva.");
            }
        }
    }
}
