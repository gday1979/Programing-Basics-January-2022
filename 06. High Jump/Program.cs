using System;

namespace _06._High_Jump
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hightTarget = double.Parse(Console.ReadLine());

            double hightActual = Math.Abs(hightTarget) - 30;

            int jumpCounterTotal = 0;
            int jumpCounterFail = 0;

            while (true)
            {

                int hightJump = int.Parse(Console.ReadLine());
                jumpCounterTotal++;

                if (hightJump > hightActual)
                {
                    jumpCounterFail = 0;

                    if (hightActual >= hightTarget)
                    {
                        Console.WriteLine("Tihomir succeeded, he jumped over {0}cm after {1} jumps.", hightTarget, jumpCounterTotal);
                        break;
                    }
                    else
                    {
                        hightActual += 5;
                        continue;
                    }

                }
                else
                {
                    jumpCounterFail++;

                    if (jumpCounterFail == 3)
                    {
                        Console.WriteLine("Tihomir failed at {0}cm after {1} jumps.", hightActual, jumpCounterTotal);
                        break;
                    }
                }
            }


        }
    }
}
