using System;

namespace _05._Fitness_Center
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double count=double.Parse(Console.ReadLine());
            double backCount = 0;
            double chestCount=0;
            double legsCount = 0;
            double absCount = 0;
            double workOutCount = 0;
            double proteinShake=0;
            double proteinBar = 0;
            double protein = 0;


            for (int i = 0; i < count; i++)
            {
                string type = Console.ReadLine();
                switch (type)
                {
                    case "Back":
                        backCount++;
                        workOutCount++;
                        break;
                    case "Chest":
                        chestCount++;
                        workOutCount++;
                        break ;
                    case "Legs":
                        legsCount++;
                        workOutCount++;
                        break;
                    case "Abs":
                        absCount++;
                        workOutCount++;
                        break;
                    case "Protein shake":
                        proteinShake++;
                        protein++;
                        break;
                    case "Protein bar":                      
                        proteinBar++;
                        protein++;
                        break;
                        

                    default:
                        break;
                }
            }
            Console.WriteLine($"{backCount} - back");
            Console.WriteLine($"{chestCount} - chest");
            Console.WriteLine($"{legsCount} - legs");
            Console.WriteLine($"{absCount} - abs");
            Console.WriteLine($"{proteinShake} - protein shake");
            Console.WriteLine($"{proteinBar} - protein bar");
            Console.WriteLine($"{workOutCount/count*100:f2}% - work out");
            Console.WriteLine($"{protein/count*100:f2}% - protein");
        }
    }
}
