using System;

namespace Vacation
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = "";
            string typeOfHousing = "";
            double price = 0;

            switch (season)
            {
                case "Summer":
                    if (budget<=1000)
                    {
                        location = "Alaska";
                        typeOfHousing = "Camp";
                        price = 0.65 * budget;
                    }
                    else if (budget>1000&&budget<=3000)
                    {
                        location = "Alaska";
                        typeOfHousing = "Hut";
                        price = 0.80 * budget;
                    }
                    else if (budget>3000)
                    {
                        location = "Alaska";
                        typeOfHousing = "Hotel";
                        price = 0.90 * budget;
                    }
                    break;
                case "Winter":
                    if (budget <= 1000)
                    {
                        location = "Morocco";
                        typeOfHousing = "Camp";
                        price = 0.45 * budget;
                    }
                    else if (budget > 1000 && budget <= 3000)
                    {
                        location = "Morocco";
                        typeOfHousing = "Hut";
                        price = 0.60 * budget;
                    }
                    else if (budget > 3000)
                    {
                        location = "Morocco";
                        typeOfHousing = "Hotel";
                        price = 0.90 * budget;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{location} - {typeOfHousing} - {price:f2}");
        }
    }
}
