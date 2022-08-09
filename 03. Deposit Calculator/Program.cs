using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            double monthDeposit = double.Parse(Console.ReadLine());
            double yearProcent = double.Parse(Console.ReadLine());
            double monthRevenue = deposit * yearProcent/100;
            double monthBenefits = monthRevenue / 12;
            double sum = deposit+ (monthDeposit * monthBenefits);
            Console.WriteLine(sum);
        }
    }
}
