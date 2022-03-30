using System;

namespace EasterPaint
{
    class Program
    {
        static void Main(string[] args)
        {
            string sizeEggs = Console.ReadLine();
            string colour = Console.ReadLine();
            int numbers = int.Parse(Console.ReadLine());
            double price = 0;
            switch (sizeEggs)
            {
                case "Large":
                    if (colour == "Red")
                    {
                        price = numbers * 16;
                    }
                    else if (colour == "Green")
                    {
                        price = numbers * 12;
                    }
                    else if (colour == "Yellow")
                    {
                        price = numbers * 9;
                    }
                    break;
                case "Medium":
                    if (colour == "Red")
                    {
                        price = numbers * 13;
                    }
                    else if (colour == "Green")
                    {
                        price = numbers * 9;
                    }
                    else if (colour == "Yellow")
                    {
                        price = numbers * 7;
                    }
                    break;
                case "Small":
                    if (colour == "Red")
                    {
                        price = numbers * 9;
                    }
                    else if (colour == "Green")
                    {
                        price = numbers * 8;
                    }
                    else if (colour == "Yellow")
                    {
                        price = numbers * 5;
                    }
                    break;
            }
            double expenses = price * 0.35;
            price -= expenses;
            Console.WriteLine($"{price:f2} leva.");
        }
    }
}
