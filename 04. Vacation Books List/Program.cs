using System;

namespace _04._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int hourPages = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int pagesPerHour = pages / hourPages;
            int hourPerDay=pagesPerHour / days;
            Console.WriteLine(hourPerDay);
 
        }
    }
}
