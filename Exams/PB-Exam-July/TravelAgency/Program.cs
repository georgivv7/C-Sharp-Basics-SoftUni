using System;

namespace TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string packet = Console.ReadLine();
            string card = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double price = 0;
           
            switch (town)
            {
                case "Bansko":
                case "Borovets":
                    if (packet == "withEquipment")
                    {
                        if (days > 7)
                        {
                            days -= 1;
                        }
                        price = 100 * days;
                        if (card == "yes")
                        {
                            price = price - price * 0.10;
                        }

                    }
                    else if (packet == "noEquipment")
                    {
                        if (days > 7)
                        {
                            days -= 1;
                        }
                        price = 80 * days;
                        if (card == "yes")
                        {
                            price = price - price * 0.05;
                        }
                    }
                    break;
                case "Burgas":
                case "Varna":
                    if (packet == "withBreakfast")
                    {
                        if (days > 7)
                        {
                            days -= 1;
                        }
                        price = 130 * days;
                        if (card == "yes")
                        {
                            price = price - price * 0.12;
                        }

                    }
                    else if (packet == "noBreakfast")
                    {
                        if (days > 7)
                        {
                            days -= 1;
                        }
                        price = 100 * days;
                        if (card == "yes")
                        {
                            price = price - price * 0.07;
                        }
                    }
                    break;
            }
            if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else if (town != "Bansko" && town != "Borovets" && town != "Varna" && town != "Burgas")
            {
                Console.WriteLine("Invalid input!");
            }
            else if (packet != "withEquipment" && packet != "noEquipment" && packet != "withBreakfast" && packet != "noBreakfast")
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                Console.WriteLine($"The price is {price:f2}lv! Have a nice time!");
            }
            
        }
    }
}
