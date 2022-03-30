using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededNaylon = int.Parse(Console.ReadLine());
            int neededPaint = int.Parse(Console.ReadLine());
            int neededRazreditel = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double priceNaylon = (2 + neededNaylon) * 1.50;
            double pricePaint = ((0.10 * neededPaint) + neededPaint) * 14.50;
            double priceRazred = neededRazreditel * 5.00;
            double materials = priceNaylon + pricePaint + priceRazred+0.40;
            double workExpenses = (materials * 0.30) * hours;
            double Allsum = materials + workExpenses;

            Console.WriteLine($"Total expenses: {Allsum:F2} lv.");

        }
    }
}
