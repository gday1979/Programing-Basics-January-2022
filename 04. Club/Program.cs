using System;

namespace _04._Club
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double expectMoney = double.Parse(Console.ReadLine()); //  500
            string inputName = Console.ReadLine();
            double totalPrice = 0.00;
            double money = 0.00;


            while (inputName != "Party!") //
            {
                int number = int.Parse(Console.ReadLine());
                double price = inputName.Length;
                totalPrice = price * number;

                if (totalPrice % 2 != 0)
                {
                    totalPrice = totalPrice - (totalPrice * 0.25);
                }

                money += totalPrice;

                if (money >= expectMoney)
                {
                    Console.WriteLine("Target acquired.");
                    break;
                }

                inputName = Console.ReadLine();
            }

            if (inputName == "Party!")
            {
                double diff = expectMoney - money;
                Console.WriteLine($"We need {diff:f2} leva more.");

            }

            Console.WriteLine($"Club income - {money:F2} leva.");

        }
    }
}
