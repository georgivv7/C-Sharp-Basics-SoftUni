using System;

namespace EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int numOfNights = int.Parse(Console.ReadLine());

            double priceTotal = 0;
            double price = 0;
            switch (destination)
            {
                case "France":
                    if (dates=="21-23")
                    {
                        price = 30;
                    }
                    else if (dates=="24-27")
                    {
                        price = 35;
                    }
                    else if (dates=="28-31")
                    {
                        price = 40;
                    }
                    break;
                case "Italy":
                    if (dates == "21-23")
                    {
                        price = 28;
                    }
                    else if (dates == "24-27")
                    {
                        price = 32;
                    }
                    else if (dates == "28-31")
                    {
                        price = 39;
                    }
                    break;
                case "Germany":
                    if (dates == "21-23")
                    {
                        price = 32;
                    }
                    else if (dates == "24-27")
                    {
                        price = 37;
                    }
                    else if (dates == "28-31")
                    {
                        price = 43;
                    }
                    break;
            }
            priceTotal = price * numOfNights;
            Console.WriteLine($"Easter trip to {destination} : {priceTotal:f2} leva.");
        }
    }
}
