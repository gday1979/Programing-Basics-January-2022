using System;

namespace _01._Match_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            double people = double.Parse(Console.ReadLine());
            double sum = 0;
            if (people >= 1 && people <= 4)
            {
                sum = 75.00;
            }
            else if (people >= 5 && people <= 9)
            {
                sum = 60.00;
            }
            else if (people >= 10 && people <= 24)
            {
                sum = 50.00;
            }
            else if (people>=25 && people<=49)
            {
                sum = 40.00;
            }
            else if (people>50)
            {
                sum = 25.00;
            }
            double budgetTransport = budget * sum / 100;
            double budgetTickets = budget - budgetTransport;
            bool enough = false;
            double reminder = 0;
            double need = 0;
            if (type=="VIP")
            {
                if (budgetTickets/people>499.99)
                {
                    enough = true;
                    reminder = budgetTickets - (people * 499.99);
                }
                else
                {
                    enough = false;
                    need = (people * 499.99) - budgetTickets;
                }
            }
            else if (type=="Normal")
            {
                if (budgetTickets/people>249.99)
                {
                    enough = true;
                    reminder = budgetTickets - (people * 249.99);
                }
                else
                {
                    enough=false;
                    need = (people * 249.99) - budgetTickets;
                }
            }
            if (enough)
            {
                Console.WriteLine($"Yes! You have {reminder:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {need:f2} leva.");
            }
        }
    }
}
