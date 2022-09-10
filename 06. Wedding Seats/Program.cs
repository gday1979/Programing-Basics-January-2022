using System;

namespace _06._Wedding_Seats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char lastSector = Console.ReadLine().ToCharArray()[0];
            byte rowsInFirstSector = byte.Parse(Console.ReadLine());
            byte seatsOnUnevenRows = byte.Parse(Console.ReadLine());

            int numberOfRowsInCurrentSector = rowsInFirstSector;
            int numberOfSeats = 0;

            for (char currentSector = 'A'; currentSector <= lastSector; currentSector++)
            {
                for (int currentRow = 1; currentRow <= numberOfRowsInCurrentSector; currentRow++)
                {
                    int lastSeat;
                    if (currentRow % 2 == 1) lastSeat = (int)'a' + seatsOnUnevenRows - 1;
                    else lastSeat = (int)'a' + seatsOnUnevenRows + 1;
                    for (char currentSeat = 'a'; (int)currentSeat <= lastSeat;)
                    {
                        Console.WriteLine("{0}{1}{2}", currentSector, currentRow, currentSeat);
                        currentSeat = (char)((int)currentSeat + 1);
                        numberOfSeats++;
                    }
                }
                numberOfRowsInCurrentSector++;
            }
            Console.WriteLine(numberOfSeats);
        }
    }
}
