using System;

namespace _05.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                string serial = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                switch (serial)
                {
                    case "Thrones":
                        price -= price * 0.50;
                        break;
                    case "Lucifer":
                        price -= price * 0.40;
                        break;
                    case "Protector":
                        price -= price * 0.30;
                        break;
                    case "TotalDrama":
                        price -= price * 0.20;
                        break;
                    case "Area":
                        price -= price * 0.10;
                        break;
                }
                budget -= price;
            }
            if (budget >= 0)
            {
                Console.WriteLine($"You bought all the series and left with {budget:f2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {Math.Abs(budget):f2} lv. more to buy the series!");
            }
        }
    }
}
