using System;

namespace _02.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double priceEquipment = double.Parse(Console.ReadLine());

            double dekor = budget * 0.10;
            if (statists>150)
            {
                priceEquipment -= priceEquipment * 0.10;
            }
            double sumStatists = priceEquipment * statists;
            double total = sumStatists + dekor;

            if (budget>=total)
            {
                budget -= total;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget:f2} leva left.");
            }
            else
            {
                total -= budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {total:F2} leva more.");
            }

        }
    }
}
