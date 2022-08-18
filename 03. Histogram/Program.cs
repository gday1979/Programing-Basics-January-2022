using System;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            double p4 = 0.0;
            double p5 = 0.0;
            int num;
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1 += 1;
                }
                else
                {
                    if (num >= 200 && num < 400)
                    {
                        p2 += 1;
                    }
                    else
                    {
                        if (num >= 400 && num < 600)
                        {
                            p3 += 1;
                        }
                        else
                        {
                            if (num >= 600 && num < 800)
                            {
                                p4 += 1;
                            }
                            else
                            {
                                if (num >= 800)
                                {
                                    p5 += 1;
                                }
                            }
                        }
                    }
                }
            }
            p1 = (p1 / n) * 100;
            Console.WriteLine("{0:f2}%", p1);
            p2 = (p2 / n) * 100;
            Console.WriteLine("{0:f2}%", p2);
            p3 = (p3 / n) * 100;
            Console.WriteLine("{0:f2}%", p3);
            p4 = (p4 / n) * 100;
            Console.WriteLine("{0:f2}%", p4);
            p5 = (p5 / n) * 100;
            Console.WriteLine("{0:f2}%", p5);
        }
    }
}
