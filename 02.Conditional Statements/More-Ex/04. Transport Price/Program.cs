using System;

namespace _04._Transport_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            double price = 0;
            if (type == "day")
            {
                if (kilometers < 20)
                {
                    price = (kilometers *0.79)+0.70;
                }
                else if (kilometers >= 20 && kilometers<100)
                {
                    price = kilometers * 0.09;
                }
                else if (kilometers > 100)
                {
                    price = kilometers * 0.06;
                }
            }
            else if (type=="night")
            {
                if (kilometers<20)
                {
                    price = (kilometers *0.90)+0.70;
                }
                else if (kilometers>=20 && kilometers<100 )
                {
                   price = kilometers * 0.09;
                }
                else if (kilometers>=100 )
                {
                    price = kilometers * 0.06;
                }
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
