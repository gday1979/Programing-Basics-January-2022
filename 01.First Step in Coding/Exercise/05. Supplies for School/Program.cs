using System;

namespace _05._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double packagePencil=double.Parse(Console.ReadLine());  
            double packageMarkers=double.Parse(Console.ReadLine()); 
            double literPreparation=double.Parse(Console.ReadLine());
            double discount=double.Parse(Console.ReadLine());
            double pricePackagePencil = packagePencil * 5.80;
            double pricePackageMarkers = packageMarkers * 7.20;
            double pricePreparation = literPreparation* 1.20;
            double priceDiscounts = discount / 100;
            double priceAll = (pricePackagePencil + pricePackageMarkers + pricePreparation);
            double sum = priceAll-(priceAll* priceDiscounts);
;            Console.WriteLine(sum);

        }
    }
}
