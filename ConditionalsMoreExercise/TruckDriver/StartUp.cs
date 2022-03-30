using System;

namespace TruckDriver
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());

            double salary = 0;

            switch (season)
            {
                case "Spring":
                case "Autumn":
                    if (kmPerMonth<=5000)
                    {
                        salary = (0.75 * kmPerMonth)*4;
                        salary -= salary * 0.10;
                    }
                    else if (kmPerMonth>5000&&kmPerMonth<=10000)
                    {
                        salary = (0.95 * kmPerMonth)*4;
                        salary -= salary * 0.10;
                    }
                    else if (kmPerMonth>10000&&kmPerMonth<=20000)
                    {
                        salary = (1.45 * kmPerMonth)*4;
                        salary -= salary * 0.10;
                    }
                    break;
                case "Summer":
                    if (kmPerMonth <= 5000)
                    {
                        salary = (0.90 * kmPerMonth)*4;
                        salary -= salary * 0.10;
                    }
                    else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                    {
                        salary = (1.10 * kmPerMonth)*4;
                        salary -= salary * 0.10;
                    }
                    else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                    {
                        salary = 1.45 * kmPerMonth*4;
                        salary -= salary * 0.10;
                    }
                    break;
                case "Winter":
                    if (kmPerMonth <= 5000)
                    {
                        salary = 1.05 * kmPerMonth*4;
                        salary -= salary * 0.10;
                    }
                    else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                    {
                        salary = 1.25 * kmPerMonth*4;
                        salary -= salary * 0.10;
                    }
                    else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                    {
                        salary = 1.45 * kmPerMonth*4;
                        salary -= salary * 0.10;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{salary:f2}");
        }
    }
}
