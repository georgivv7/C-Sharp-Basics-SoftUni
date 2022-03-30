using System;

namespace EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            double priceForOne = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double expenses = 0;
            double cake = budget * 0.10;
            if (numOfPeople >= 10 && numOfPeople <= 15)
            {
                priceForOne -= priceForOne * 0.15;
            }
            else if (numOfPeople > 15 && numOfPeople <= 20)
            {
                priceForOne -= priceForOne * 0.20;
            }
            else if (numOfPeople>20)
            {
                priceForOne -= priceForOne * 0.25;
            }
            expenses = numOfPeople * priceForOne + cake;

            if (budget>expenses)
            {
                budget -= expenses;
                Console.WriteLine($"It is party time! {budget:f2} leva left.");
            }
            else
            {
                expenses -= budget;
                Console.WriteLine($"No party! {expenses:f2} leva needed.");
            }
        }
    }
}
