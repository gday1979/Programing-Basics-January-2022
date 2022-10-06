using System;

namespace _09.Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine()); 
            double height = double.Parse(Console.ReadLine());
            double procent=double.Parse(Console.ReadLine());
            double volumeAquarium = (lenght * width * height) * 0.001;
            double neededLiters = volumeAquarium -(volumeAquarium * procent)/100;
            Console.WriteLine(neededLiters);
        }
    }
}
