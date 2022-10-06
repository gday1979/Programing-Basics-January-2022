using System;

namespace _07._School_Camp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season=Console.ReadLine();
            string gender=Console.ReadLine();
            double students=double.Parse(Console.ReadLine());
            double nights=double.Parse(Console.ReadLine());
            double total = 0;
            string sports = "";
            switch (season)
            {
                case "Winter":
                    if (gender=="boys"||gender=="girls")
                    {
                        if (gender=="girls")
                        {
                            sports = "Gymnastics";
                        }
                        else if (gender=="boys")
                        {
                            sports = "Judo";
                        }
                        total = students * nights * 9.60;
                    }
                    else if (gender=="mixed")
                    {
                        total = students * nights * 10;
                        sports = "Ski";
                    }
                    break;
                case "Spring":
                    if (gender=="boys" || gender=="girls")
                    {
                        if (gender=="girls")
                        {
                            sports = "Athletics";
                        }
                        else if (gender=="boys")
                        {
                            sports = "Tennis";
                        }
                        total = students * nights * 7.20;
                    }
                    else if (gender=="mixed")
                    {
                        total = students * nights * 9.50;
                        sports = "Cycling";
                    }
                    break ;
                case "Summer":
                    if (gender=="boys"|| gender=="girls")
                    {
                        if (gender=="girls")
                        {
                            sports = "Volleyball";
                        }
                        else if (gender=="boys")
                        {
                            sports = "Football";
                        }
                        total = students * nights * 15;
                    }
                    else if (gender=="mixed")
                    {
                        total = students * nights * 20;
                        sports = "Swimming";
                    }
                
                    break;
            }
            double discount = 0;
            if (students >=50)
            {
               discount = total - (total * 0.50);
            }
            else if (students>=20 && students <50)
            {
                discount = total - (total * 0.15);
            }
            else if (students>=10 && students<20)
            {
                discount = total - (total * 0.05);
            }
            else
            {
                discount=total;
            }
            Console.WriteLine($"{sports} {discount:f2} lv.");
        }
    }
}
