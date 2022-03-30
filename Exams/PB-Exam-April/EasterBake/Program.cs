using System;

namespace EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBreads = int.Parse(Console.ReadLine());
            double sugarSum = 0;
            double flourSum = 0;
            int maxSugar = 0;
            int maxFlour = 0;
            for (int i = 1; i <= easterBreads; i++)
            {
                int sugarInGr = int.Parse(Console.ReadLine());
                if (sugarInGr>maxSugar)
                {
                    maxSugar = sugarInGr;
                }
                sugarSum += sugarInGr;
                int flourInGr = int.Parse(Console.ReadLine());
                if (flourInGr>maxFlour)
                {
                    maxFlour = flourInGr;
                }
                flourSum += flourInGr;

            }
            sugarSum = sugarSum / 950;
            flourSum = flourSum / 750;
            Console.WriteLine($"Sugar: {Math.Ceiling(sugarSum)}");
            Console.WriteLine($"Flour: {Math.Ceiling(flourSum)}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
        }
    }
}
