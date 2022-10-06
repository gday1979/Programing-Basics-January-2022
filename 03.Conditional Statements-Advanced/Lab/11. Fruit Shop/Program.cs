using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price;
            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = quantity * 2.50;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "apple":
                        price = quantity * 1.20;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "orange":
                        price = quantity * 0.85;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "grapefruit":
                        price = quantity * 1.45;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "kiwi":
                        price = quantity * 2.70;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "pineapple":
                        price = quantity * 5.50;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "grapes":
                        price = quantity * 3.85;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "beer":
                        Console.WriteLine("error");
                        break;
                    case "tomato":
                        Console.WriteLine("error");
                        break;

                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = quantity * 2.70;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "apple":
                        price = quantity * 1.25;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "orange":
                        price = quantity * 0.90;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "grapefruit":
                        price = quantity * 1.60;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "kiwi":
                        price = quantity * 3.00;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "pineapple":
                        price = quantity * 5.60;
                        Console.WriteLine($"{price:f2}");
                        break;
                    case "grapes":
                        price = quantity * 4.20;
                        Console.WriteLine($"{price:f2}");
                        break;

                    default:
                        
                        break;
                } 
                
            }
            else
            {
                Console.WriteLine("error");
            }
            
        }
    }
}
