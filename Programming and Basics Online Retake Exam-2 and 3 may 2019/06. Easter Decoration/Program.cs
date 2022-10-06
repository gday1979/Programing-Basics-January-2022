using System;

namespace _06._Easter_Decoration
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int countClients=int.Parse(Console.ReadLine());
            double total = 0;
           
            double allSum = 0;
            for (int i = 1; i <= countClients; i++)
            {
                double daylyMoney = 0;
                int countPurchase = 0;
                string input=Console.ReadLine();
                while (input !="Finish")
                {
                    
                    string typeOfProducts=(input);
                    if (typeOfProducts == "basket")
                    {
                        daylyMoney += 1.50;
                    }
                    else if (typeOfProducts == "wreath")
                    {
                        daylyMoney += 3.80;
                      
                    }
                    else if (typeOfProducts == "chocolate bunny")
                    {
                        daylyMoney += 7;
                    }
                    total=daylyMoney;

                    countPurchase++;
                    input = Console.ReadLine();
                    
                }
                if (countPurchase%2==0)
                {
                    
                    total *= 0.80;
                }
                allSum+=total;
                
                
                Console.WriteLine($"You purchased {countPurchase} items for {total:f2} leva.");
               
            }
            Console.WriteLine($"Average bill per client is: {allSum/countClients:f2} leva.");
            
        }
    }
}
