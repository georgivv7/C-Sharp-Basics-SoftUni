using System;

namespace MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string years = Console.ReadLine();
            string type = Console.ReadLine();
            string internet = Console.ReadLine();
            double months = double.Parse(Console.ReadLine());
            double price = 0;
            switch (type)
            {
                case "Small":
                    if (years == "one")
                    {
                        price = 9.98;
                        if (internet == "yes")
                        {
                            price += 5.50;
                        }
                        price *= months;
                    }
                    if (years == "two")
                    {
                        price = 8.58;
                        if (internet == "yes")
                        {
                            price += 5.50;
                        }
                        price *= months;
                        price -= price * 0.0375;
                    }
                    break;
                case "Middle":
                    if (years == "one")
                    {
                        price = 18.99;
                        if (internet == "yes")
                        {
                            price += 4.35;
                        }
                        price *= months;
                    }
                    if (years == "two")
                    {
                        price = 17.09;
                        if (internet == "yes")
                        {
                            price += 4.35;
                        }
                        price *= months;
                        price -= price * 0.0375;
                    }
                    break;
                case "Large":
                    if (years == "one")
                    {
                        price = 25.98;
                        if (internet == "yes")
                        {
                            price += 4.35;
                        }
                        price *= months;
                    }
                    if (years == "two")
                    {
                        price = 23.59;
                        if (internet == "yes")
                        {
                            price += 4.35;
                        }
                        price *= months;
                        price -= price * 0.0375;
                    }
                    break;
                case "ExtraLarge":
                    if (years == "one")
                    {
                        price = 35.99;
                        if (internet == "yes")
                        {
                            price += 3.85;
                        }
                        price *= months;
                    }
                    if (years == "two")
                    {
                        price = 31.79;
                        if (internet == "yes")
                        {
                            price += 3.85;
                        }
                        price *= months;
                        price -= price * 0.0375;
                    }
                    break;
            }
            Console.WriteLine($"{price:F2} lv.");
        }
    }
}
