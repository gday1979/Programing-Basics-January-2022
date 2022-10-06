using System;

namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int facebook = 150;
            int instagram = 100;
            int reddit = 50;
            int n=int.Parse(Console.ReadLine());
            int salary=int.Parse(Console.ReadLine());
            
           
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine(); 
                

                if (word =="Facebook")
                {
                    salary -= facebook;
                    
                }
                else if (word=="Instagram")
                {
                    salary -= instagram;
                }
                else if (word=="Reddit")
                {
                     salary -= reddit;
                }
                else
                {
                    salary -= 0;
                }
            }
            if (salary <=0)
            {
                Console.WriteLine("You have lost your salary.");
                
            }
            else 
            {
                Console.WriteLine($"{salary}");
            }
            
        }
    }
}
