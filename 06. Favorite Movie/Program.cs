using System;

namespace _06._Favorite_Movie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentPoints = 0;
            double maxPointsMovie = double.MinValue;
            string bestMovie = string.Empty;
            int counter = 0;

            string movie = Console.ReadLine();
            while (movie != "STOP")
            {
                counter++;

                if (counter == 7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }

                foreach (char currentChar in movie)
                {
                    if (char.IsUpper(currentChar))
                    {
                        currentPoints += currentChar - movie.Length;
                    }
                    else if (char.IsLower(currentChar))
                    {
                        currentPoints += currentChar - (movie.Length * 2);
                    }
                    else
                    {
                        currentPoints += currentChar;
                    }
                }

                if (maxPointsMovie < currentPoints)
                {
                    maxPointsMovie = currentPoints;
                    bestMovie = movie;
                }

                currentPoints = 0;
                movie = Console.ReadLine();
            }

            Console.WriteLine($"The best movie for you is {bestMovie} with {maxPointsMovie} ASCII sum.");
        }
    }
}
