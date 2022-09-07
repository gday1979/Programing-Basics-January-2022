using System;

namespace _02._Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int doctors = 7;
            
            int sumTreated = 0;
            int sumNotTreated = 0;
            
            for (int i = 1; i <= period; i++)
            {
                if (i%3==0)
                {
                    if (sumNotTreated>sumTreated)
                    {
                        doctors++;
                    }
                }
                int patient = int.Parse(Console.ReadLine());
                if (doctors<patient)
                {
                    sumTreated+=doctors;
                    sumNotTreated+=patient-doctors;
                    
                }
                else 
                {
                   sumTreated+=patient;
                }
                
            }
            Console.WriteLine($"Treated patients: {sumTreated}.");
            Console.WriteLine($"Untreated patients: {sumNotTreated}.");
        }
    }
}
