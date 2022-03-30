using System;

namespace Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double targetIncome = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double order = 0;
            double income = 0;
            double priceCocktail=0;
            while (true)
            {
                
                if (input=="Party!")
                {
                    targetIncome -= income; 
                    Console.WriteLine($"We need {Math.Abs(targetIncome):F2} leva more."); 
                    break;
                }
                double numOFCocktails = double.Parse(Console.ReadLine());
                priceCocktail = input.Length;
                order = priceCocktail * numOFCocktails;
                if (order%2!=0)
                {
                    order -= order * 0.25;
                }
                income += order;
                if (income>=targetIncome)
                {
                    Console.WriteLine("Target acquired.");
                    break;
                }
                input =Console.ReadLine();
            }
            Console.WriteLine($"Club income - {income:f2} leva.");
        }
    }
}
