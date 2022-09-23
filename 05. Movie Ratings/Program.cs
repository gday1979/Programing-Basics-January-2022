using System;

namespace _05._Movie_Ratings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moviesCount = int.Parse(Console.ReadLine());

            double maxRating = double.MinValue;
            double minRating = double.MaxValue;
            double totalRating = 0;
            double averageRating = 0;

            string filmName = "";
            string bestFilm = "";
            string badFilm = "";


            for (int i = 0; i < moviesCount; i++)
            {
                filmName = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());

                if (rating > maxRating)
                {
                    maxRating = rating;
                    bestFilm = filmName;
                }

                if (minRating >rating)
                {
                    minRating = rating;
                    badFilm = filmName;
                }
                totalRating += rating;
                averageRating = totalRating * 1.0 / moviesCount;



            }

            Console.WriteLine($"{bestFilm} is with highest rating: {maxRating}");
            Console.WriteLine($"{badFilm} is with lowest rating: {minRating}");
            Console.WriteLine($"Average rating: {averageRating:f1}");
        }
    }
}
