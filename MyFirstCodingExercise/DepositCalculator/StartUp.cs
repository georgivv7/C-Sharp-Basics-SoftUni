using System;

namespace DepositCalculator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int interestInMonths = int.Parse(Console.ReadLine());
            double interestForYear = double.Parse(Console.ReadLine());

            double interest = deposit * interestForYear / 100;
            double interestPerMonth = interest / 12;
            double AllSum = deposit + interestInMonths * interestPerMonth;

            Console.WriteLine($"{AllSum:f2}");

            
                
        }
    }
}
