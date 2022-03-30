using System;

namespace Flowers1
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int quantityHriz = int.Parse(Console.ReadLine());
            int quantityRoses = int.Parse(Console.ReadLine());
            int quantityTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string ifHoliday = Console.ReadLine();

            double sum = 0;
            double price = 0;
            double sumQuantity = quantityHriz + quantityRoses + quantityTulips;

            switch (ifHoliday)
            {
                case "Y":
                    if (season == "Spring" || season == "Summer")
                    {
                        sum = quantityHriz * 2 + quantityRoses * 4.10 + quantityTulips * 2.50;
                        price = sum + (sum * 0.15);
                        if (quantityTulips > 7&& season == "Spring")
                        {
                            price = price - (price * 0.05);
                        }
                        if (sumQuantity > 20)
                        {
                            price = price - (price * 0.20);
                        }
                    }
                    else if (season == "Winter" || season == "Autumn")
                    {
                        sum = quantityHriz * 3.75 + quantityRoses * 4.50 + quantityTulips * 4.15;
                        price = sum + (sum * 0.15);
                        if (quantityRoses >= 10&& season == "Winter")
                        {
                            price = price - (price * 0.10);
                        }
                        if (sumQuantity > 20)
                        {
                            price = price - (price * 0.20);
                        }

                    }
                    break;
                case "N":
                    if (season == "Spring" || season == "Summer")
                    {
                        price = quantityHriz * 2 + quantityRoses * 4.10 + quantityTulips * 2.50;
                        if (quantityTulips > 7&&season=="Spring")
                        {
                            price = price - (price * 0.05);
                        }
                        if (sumQuantity > 20)
                        {
                            price = price - (price * 0.20);
                        }
                    }
                    else if (season == "Winter" || season == "Autumn")
                    {
                        price = quantityHriz * 3.75 + quantityRoses * 4.50 + quantityTulips * 4.15;
                        if (quantityRoses >= 10&&season=="Winter")
                        {
                            price = price - (price * 0.10);
                        }
                        if (sumQuantity > 20)
                        {
                            price = price - (price * 0.20);
                        }
                    }
                    break;
            }
            Console.WriteLine($"{price + 2:f2}");
        }
    }
}
