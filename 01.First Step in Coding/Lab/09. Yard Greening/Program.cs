using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double qudrantMeters = double.Parse(Console.ReadLine());
            double oneQudrant = 7.61;
            double price = (qudrantMeters * oneQudrant);
            double discountAllPrice = price * 0.18;

            double allPrice = price - discountAllPrice;
                
            Console.WriteLine($"The final price is: {allPrice} lv.");
            Console.WriteLine($"The discount is: {discountAllPrice} lv.");

        }
    }
}
