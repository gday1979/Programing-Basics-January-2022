using System;

namespace _04._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double groupsOfClimber=double.Parse(Console.ReadLine());
            double counterClimbers=0;
            double groupMusala = 0;
            double groupMontBlanc = 0;
            double groupKilimandjaro = 0;
            double groupK2 = 0;
            double groupEverest = 0;
            for (int i = 1; i <=groupsOfClimber; i++)
            {            
                double numberOfClimber = double.Parse(Console.ReadLine());
                if (numberOfClimber<=5)
                {
                    counterClimbers += numberOfClimber;
                    groupMusala+=numberOfClimber;
                }
                else if (numberOfClimber>=6 && numberOfClimber<=12)
                {
                     counterClimbers += numberOfClimber;
                    groupMontBlanc+=numberOfClimber;
                }
                else if (numberOfClimber>=13 && numberOfClimber<=25)
                {
                    counterClimbers += numberOfClimber;
                    groupKilimandjaro+=numberOfClimber;
                }
                else if (numberOfClimber>=26 && numberOfClimber<=40)
                {
                    counterClimbers += numberOfClimber;
                    groupK2+=numberOfClimber;
                }
                else if (numberOfClimber>=41)
                {
                    counterClimbers += numberOfClimber;
                    groupEverest+=numberOfClimber;
                }
            }
            
            Console.WriteLine($"{groupMusala/counterClimbers*100:f2}%");
            Console.WriteLine($"{groupMontBlanc/counterClimbers*100:f2}%");
            Console.WriteLine($"{groupKilimandjaro/counterClimbers*100:f2}%");
            Console.WriteLine($"{groupK2/counterClimbers*100:f2}%");
            Console.WriteLine($"{groupEverest/counterClimbers*100:f2}%");
        }
    }
}
