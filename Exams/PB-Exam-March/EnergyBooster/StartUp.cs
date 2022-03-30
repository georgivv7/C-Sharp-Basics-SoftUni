using System;

namespace EnergyBooster
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int numOfSets = int.Parse(Console.ReadLine());

            double price = 0;
            double discount = 0;
            switch (fruit)
            {
                case "Watermelon":
                    if (size=="small")
                    {
                        price = 2 * 56;
                        
                    }
                    else if (size=="big")
                    {
                        price = 5 * 28.70;
                    }
                    break;
                case"Mango":
                    if (size == "small")
                    {
                        price = 2 * 36.66;

                    }
                    else if (size == "big")
                    {
                        price = 5 * 19.60;
                    }
                    break;
                case "Pineapple":
                    if (size == "small")
                    {
                        price = 2 * 42.10;

                    }
                    else if (size == "big")
                    {
                        price = 5 * 24.80;
                    }
                    break;
                case "Raspberry":
                    if (size == "small")
                    {
                        price = 2 * 20;

                    }
                    else if (size == "big")
                    {
                        price = 5 * 15.20;
                    }
                    break;
            }
            price *= numOfSets;
            if (price>=400&&price<=1000)
            {
                discount = 0.15 * price;
                price -= discount; 
            }
            else if (price>1000)
            {
                discount = 0.50 * price;
                price -= discount;
            }
            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
