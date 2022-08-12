using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double budgetFilm=double.Parse(Console.ReadLine());
            double peopleExtra=double.Parse(Console.ReadLine());    
            double pricePeopleExtra=double.Parse(Console.ReadLine());
            double decor = budgetFilm * 0.10;
            double allPricePeopleExtra = peopleExtra * pricePeopleExtra;
            double discountPricePeopleExtra=0.00;
            if (peopleExtra > 150)
            {
                discountPricePeopleExtra = (peopleExtra * pricePeopleExtra) * 0.10;
            }
            else
            {
                discountPricePeopleExtra = allPricePeopleExtra;
            }
            
                 double allBudget = decor + allPricePeopleExtra;
            if (allBudget > budgetFilm)
            {
                double neededMoney = allBudget - budgetFilm;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:f2}");
            }
            else if (allBudget <= budgetFilm)
            {
                double noneed=budgetFilm - allBudget;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {noneed:f2} leva left.");

            }

            }
        }
    }

