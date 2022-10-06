using System;

namespace _03._Travel_Agency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city=Console.ReadLine();
            string package=Console.ReadLine();
            string discount=Console.ReadLine();
            double days=double.Parse(Console.ReadLine());
            double price = 0;
          
                if (city == "Borovets" || city == "Bansko")
                {
                    if (package == "withEquipment")
                    {
                        price = 100;
                        if (discount == "yes")
                        {
                            price = price - (price * 0.10);
                            price = price * days;
                        }
                        else
                        {
                            price *= days;
                        }
                    }
                    else if (package == "noEquipment")
                    {
                        price = 80;
                        if (discount == "yes")
                        {
                            price = price - (price * 0.05);
                            price = price * days;
                        }
                        else
                        {
                            price *= days;
                        }
                    }

                }
                else if (city == "Varna" || city == "Burgas")
                {
                    if (package == "withBreakfast")
                    {
                        price = 130;
                        if (discount == "yes")
                        {
                            price = price - (price * 0.12);
                            price = price * days;
                        }
                        else
                        {
                            price *= days;
                        }
                    }
                    else if (package == "noBreakfast")
                    {
                        price = 100;
                        if (discount == "yes")
                        {
                            price = price - (price * 0.07);
                            price = days * price;
                        }
                        else
                        {
                            price *= days;
                        }
                    }
                }
            
            if (price>0)
            { 
                Console.WriteLine($"The price is {price:f2}lv! Have a nice time!");
            }
            else if (days<1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else
{
    Console.WriteLine("Invalid input!");
}

        }
    }
}
		