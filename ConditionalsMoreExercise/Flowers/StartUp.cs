using System;

namespace Flowers
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

            switch (season)
            {
                case "Spring":
                    sum = quantityHriz * 2 + quantityRoses * 4.10 + quantityTulips * 2.50;
                    if (ifHoliday == "Y")
                    {
                        price = sum + (sum*0.15);
                        if (quantityTulips > 7)
                        {
                            price -= price * 0.05;
                        }
                        else if (sumQuantity > 20)
                        {
                            price -= price * 0.20;
                        }
                    }
                    else
                    {
                        price = sum;
                    }
                    break;
                case "Summer":
                    sum = quantityHriz * 2 + quantityRoses * 4.10 + quantityTulips * 2.50;
                    if (ifHoliday=="Y")
                    {
                        price = sum + (sum * 0.15);

                        if (sumQuantity>20)
                        {
                            price -= price * 0.20;
                        }
                    }
                    else
                    {
                        price = sum;
                    }
                    break;
                case "Autumn":
                    sum = quantityHriz * 3.75 + quantityRoses * 4.50 + quantityTulips * 4.15;
                    if (ifHoliday == "Y")
                    {
                        price = sum + (sum * 0.15);

                        if (sumQuantity > 20)
                        {
                            price -= price * 0.20;
                        }
                    }
                    else
                    {
                        price = sum;
                    }
                    break;
                case "Winter":
                    sum = quantityHriz * 3.75 + quantityRoses * 4.50 + quantityTulips * 4.15;
                    if (ifHoliday == "Y")
                    {
                        price = sum + (sum * 0.15);
                        if (quantityRoses >= 10)
                        {
                            price -= price * 0.10;
                        }                     
                        else if (sumQuantity > 20)
                        {
                            price -= price * 0.20;
                        }
                    }
                    else if (ifHoliday=="N")
                    {
                        if (quantityRoses >= 10)
                        {
                            price = sum-(sum * 0.10);
                        }
                        else if (sumQuantity > 20)
                        {
                            price = sum-(sum * 0.20);
                        }
                        
                    }
                    else
                    {
                        price = sum;
                    }
                    break;
                
            }
            Console.WriteLine($"{price+2:f2}");

        }
    }
}
