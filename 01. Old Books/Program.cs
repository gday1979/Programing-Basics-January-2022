using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counterBooks = 0;
            bool isBookFound=false;
            string book=Console.ReadLine();
            while (book != "No More Books")
            {

                if (book == input)
                {
                    isBookFound = true;
                    break;
                }
                counterBooks++;
                book = Console.ReadLine();
                
            }
            if (isBookFound)
            {
                Console.WriteLine($"You checked {counterBooks} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counterBooks} books.");
            }
        }
    }
}
