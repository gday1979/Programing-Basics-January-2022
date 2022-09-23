using System;

namespace _06._Cinema_Ticketss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            byte numStudent = 0;
            byte numStandard = 0;
            byte numKid = 0;
            while (movie != "Finish")
            {
                byte seats = byte.Parse(Console.ReadLine());
                byte movieTickets = 0;
                for (int i = 0; i < seats; i++)
                {
                    string seatType = Console.ReadLine();
                    if (seatType == "End")
                    {
                        break;
                    }
                    else if (seatType == "student")
                    {
                        numStudent++;
                    }
                    else if (seatType == "standard")
                    {
                        numStandard++;
                    }
                    else if (seatType == "kid")
                    {
                        numKid++;
                    }
                    movieTickets++;
                }
                Console.WriteLine($"{movie} - {(float)movieTickets / seats * 100:f2}% full.");
                movie = Console.ReadLine();
            }
            int totalTickets = numStudent + numStandard + numKid;
            string output = string.Format($"Total tickets: {numStudent + numStandard + numKid}\n" +
                $"{(float)numStudent / totalTickets * 100f:f2}% student tickets.\n" +
                $"{(float)numStandard / totalTickets * 100f:f2}% standard tickets.\n" +
                $"{(float)numKid / totalTickets * 100f:f2}% kids tickets.");
            Console.WriteLine(output);
        }
    }
}
