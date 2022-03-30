using System;

namespace BackToThePast
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            int yearsOfLiving = int.Parse(Console.ReadLine());

            int age = 18;
            double expenses = 0;
                      

            for (int year = 1800; year <= yearsOfLiving; year++)
            {
                if (year%2==0)
                {
                    expenses = 12000;
                    heritage-=expenses;
                }
                else 
                {                  
                    expenses = 12000 + (50 * age);
                    heritage -= expenses;
                }
                age++;
            }         
            if (heritage>=0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {heritage:f2} dollars left.");
            }       
            else
            {
                Console.WriteLine($"He will need {Math.Abs(heritage):f2} dollars to survive.");
            }
            
        }
    }
}
