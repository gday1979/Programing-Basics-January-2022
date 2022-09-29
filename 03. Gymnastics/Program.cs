using System;
namespace _03._Gymnastics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country=Console.ReadLine();
            string type=Console.ReadLine();
            double maxEvaluation = 20;
            double difficulty = 0;
            double performance = 0;
            double allEvaluation = 0;
            double procentNeed=0;
            switch (country)
            {
                case "Russia":
                    switch (type)
                    {
                        case "ribbon":
                            difficulty = 9.100;
                            performance = 9.400;
                            allEvaluation = difficulty + performance;
                            procentNeed = allEvaluation / maxEvaluation * 100;
                            break;
                        case "hoop":
                            difficulty = 9.300;
                            performance = 9.800;
                            allEvaluation = difficulty + performance;
                            procentNeed = allEvaluation / maxEvaluation * 100;
                            break ;
                        case "rope":
                            difficulty = 9.300;
                            performance = 9.800;
                            allEvaluation = difficulty + performance;
                            procentNeed = allEvaluation / maxEvaluation * 100;
                            break;
                    }
                    break;
                case "Bulgaria":
                    switch (type)
                    {
                        case "ribbon":
                            difficulty = 9.600;
                            performance = 9.400;
                            allEvaluation = difficulty + performance;
                            procentNeed = allEvaluation / maxEvaluation * 100;
                            break;
                        case "hoop":
                            difficulty = 9.550;
                            performance = 9.750;
                            allEvaluation = difficulty + performance;
                            procentNeed = allEvaluation / maxEvaluation * 100;
                            break;
                        case "rope":
                            difficulty = 9.500;
                            performance = 9.400;
                            allEvaluation = difficulty + performance;
                            procentNeed = allEvaluation / maxEvaluation * 100;
                            break;
                    }
                    break ;
                case "Italy":
                    switch (type)
                    {
                        case "ribbon":
                            difficulty = 9.600;
                            performance = 9.400;
                            allEvaluation = difficulty + performance;
                            procentNeed = allEvaluation / maxEvaluation * 100;
                            break;
                        case "hoop":
                            difficulty = 9.550;
                            performance = 9.750;
                            allEvaluation = difficulty + performance;
                            procentNeed = allEvaluation / maxEvaluation * 100;
                            break;
                        case "rope":
                            difficulty = 9.500;
                            performance = 9.400;
                            allEvaluation = difficulty + performance;
                            procentNeed = allEvaluation / maxEvaluation * 100;
                            break;

                    }
                    break;
                        default:
                    break;
            }
            double diference=maxEvaluation-allEvaluation;
            Console.WriteLine($"The team {country} get {allEvaluation} on {type}");
            Console.WriteLine($"{diference / maxEvaluation * 100}%");
        }
    }
}
