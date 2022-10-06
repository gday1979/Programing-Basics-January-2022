using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Threading;

namespace _04._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int capacity=int.Parse(Console.ReadLine());
            
            int sum = 0;
            string comand=Console.ReadLine();

            while (comand != "Movie time!")
            {
                int countPeople = int.Parse(comand);
                capacity -= countPeople;
                if (capacity<0)
                {
                    break;
                }

                if (countPeople % 3 == 0)
                {
                    sum += (countPeople * 5) - 5;

                }
                else
                {
                    sum+=countPeople * 5;
                }
                
                comand = Console.ReadLine();
            }
            if (capacity>0 || capacity==0)
            {
                Console.WriteLine($"There are {capacity} seats left in the cinema.");
            }
            else
            {
                Console.WriteLine("The cinema is full.");
            }
            Console.WriteLine($"Cinema income - {sum} lv. ");
        }
    }
}
