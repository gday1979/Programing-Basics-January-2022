using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            double result;
            string evenOrOdd = "odd";
            switch (sign)
            {
                case "+":
                    result = numberOne + numberTwo;
                    if (result %2==0)
                    {
                        evenOrOdd="even";
                    }
                    Console.WriteLine($"{numberOne} + {numberTwo} = {result} - {evenOrOdd}");
                    break;
                case "-":
                    result = numberOne - numberTwo;
                    Console.WriteLine($"{numberOne} - {numberTwo} = {result} - {evenOrOdd}");
                    break;
                case "*":
                    result = numberOne * numberTwo;
                    Console.WriteLine($"{numberOne} * {numberTwo} = {result} - {evenOrOdd}");
                    break;
                case "/":
                    if (numberTwo==0)
                    {
                        Console.WriteLine($"Cannot divide {numberOne} by zero");
                    }
                    result = numberOne / numberTwo;
                    Console.WriteLine($"{numberOne} / {numberTwo} = {result}");
                    break;
                case "%":
                    result = numberOne / numberTwo;
                    Console.WriteLine($" {numberOne} % {numberTwo} = {result}");
                    break;
                default:
                    break;
            }
            
        }
    }
}
