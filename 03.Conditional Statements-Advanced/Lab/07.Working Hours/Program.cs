﻿using System;

namespace _07.Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            if (hour >= 10 && hour <= 18)
            {
                switch (day)
                {
                    case "Moday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                    case "Saturday":
                        Console.WriteLine("open");
                        break;
                    case "Sunday":
                    default:
                        Console.WriteLine("closed");
                        break;

                }
                
            }
            else
            {
                
                Console.WriteLine("closed");
            }
        }
    }
}
