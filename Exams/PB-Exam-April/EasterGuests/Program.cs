using System;

namespace EasterGuests
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOfGuests = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double numOfEasterBreads = Math.Ceiling(numOfGuests / 3);
            double numOfEggs = numOfGuests * 2;
            double priceEasterBread = numOfEasterBreads * 4;
            double priceEggs = numOfEggs * 0.45;
            double sum = priceEasterBread + priceEggs;
            if (sum<=budget)
            {
                budget -= sum;
                Console.WriteLine($"Lyubo bought {numOfEasterBreads} Easter bread and {numOfEggs} eggs.");
                Console.WriteLine($"He has {budget:f2} lv. left.");
            }
            else
            {
                sum -= budget;
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {sum:f2} lv. more.");
            }
        }
    }
}
