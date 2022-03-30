using System;

namespace Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double litresFuel = double.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            double priceFuel = litresFuel * 2.10;
            double price = priceFuel + 100;
            if (dayOfWeek=="Saturday")
            {
                price -= price * 0.10;
            }
            else if(dayOfWeek=="Sunday")
            {
                price -= price * 0.20;
            }
            if (budget>=price)
            {
                budget -= price;
                Console.WriteLine($"Safari time! Money left: {budget:F2} lv.");
            }
            else
            {
                price -= budget;
                Console.WriteLine($"Not enough money! Money needed: {price:f2} lv.");
            }

        }
    }
}
