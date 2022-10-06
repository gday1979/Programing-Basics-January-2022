using System;

namespace _04._Cinema_Voucher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vaucher = int.Parse(Console.ReadLine());
            string take = Console.ReadLine();
            double tiketPrice = 0;
            int count = 0;
            int countProduct = 0;
            int tiketCount = 0;
            while (take != "End")
            {
                if (take.Length > 8)
                {
                    char one = take[0];
                    char two = take[1];
                    tiketPrice = one + two;
                    if (tiketPrice <= vaucher)
                    {
                        count++;
                        tiketCount++;
                        vaucher = vaucher - tiketPrice;
                    }
                    else
                    {
                        break;
                    }

                }
                else if (take.Length <= 8)
                {
                    char one = take[0];
                    if (one < vaucher)
                    {
                        countProduct++;
                        vaucher = vaucher - one;
                    }
                    else
                    {
                        break;
                    }
                }

                take = Console.ReadLine();
            }
            Console.WriteLine($"{tiketCount}");
            Console.WriteLine($"{countProduct}");
        }
    }
}