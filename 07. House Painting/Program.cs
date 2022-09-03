using System;

namespace _07._House_Painting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double heightHouse = double.Parse(Console.ReadLine());
            double widhtHouse=double.Parse(Console.ReadLine());
            double highRough=double.Parse(Console.ReadLine());
            double green = 3.4;
            double red = 4.3;
            double sides = heightHouse * widhtHouse * 2;
            double window = 1.5 * 1.5;
            double sumSides = sides - (window * 2);
            double backSides = heightHouse * heightHouse;
            double entrance = 2 * 1.2;
            double sumBack = (backSides+backSides)-entrance;
            double allArea = sumSides + sumBack;
            double sumGreen = allArea / green;
            double rough = (heightHouse*widhtHouse)*2;
            double triangle = 2 * (heightHouse * highRough/2) ;
            double sumRed = (rough + triangle) / red;
            Console.WriteLine($"{sumGreen:f2}");
            Console.WriteLine($"{sumRed:f2}");

        }
    }
}
