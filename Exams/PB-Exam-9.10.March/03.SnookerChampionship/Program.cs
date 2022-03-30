using System;

namespace _03.SnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            string finals = Console.ReadLine();
            string typeTicket = Console.ReadLine();
            int numTickets = int.Parse(Console.ReadLine());
            char picture = char.Parse(Console.ReadLine());

            double price = 0;
            switch (typeTicket)
            {
                case"Standard":
                    if (finals=="Quarter final")
                    {
                        price = 55.50 * numTickets;
                        if (price>4000)
                        {
                            price -= price * 0.25;
                        }
                        else if (price>2500&&price<=4000)
                        {
                            price -= price * 0.10;
                            if (picture=='Y')
                            {
                                price += 40 * numTickets; 
                            }
                        }
                        else
                        {
                            if (picture == 'Y')
                            {
                                price += 40 * numTickets;
                            }
                        }
                    }
                    if (finals == "Semi final")
                    {
                        price = 75.88 * numTickets;
                        if (price > 4000)
                        {
                            price -= price * 0.25;
                        }
                        else if (price > 2500 && price <= 4000)
                        {
                            price -= price * 0.10;
                            if (picture == 'Y')
                            {
                                price += 40 * numTickets;
                            }
                        }
                        else
                        {
                            if (picture == 'Y')
                            {
                                price += 40 * numTickets;
                            }
                        }
                    }
                    if (finals == "Final")
                    {
                        price = 110.10 * numTickets;
                        if (price > 4000)
                        {
                            price -= price * 0.25;
                        }
                        else if (price > 2500 && price <= 4000)
                        {
                            price -= price * 0.10;
                            if (picture == 'Y')
                            {
                                price += 40 * numTickets;
                            }
                        }
                        else
                        {
                            if (picture == 'Y')
                            {
                                price += 40 * numTickets;
                            }
                        }
                    }
                    break;
                case "Premium":
                    if (finals == "Quarter final")
                    {
                        price = 105.20 * numTickets;
                        if (price > 4000)
                        {
                            price -= price * 0.25;
                        }
                        else if (price > 2500 && price <= 4000)
                        {
                            price -= price * 0.10;
                            if (picture == 'Y')
                            {
                                price += 40 * numTickets;
                            }
                        }
                        else
                        {
                            if (picture == 'Y')
                            {
                                price += 40 * numTickets;
                            }
                        }
                    }
                    if (finals == "Semi final")
                    {
                        price = 125.22 * numTickets;
                        if (price > 4000)
                        {
                            price -= price * 0.25;
                        }
                        else if (price > 2500 && price <= 4000)
                        {
                            price -= price * 0.10;
                            if (picture == 'Y')
                            {
                                price += 40 * numTickets;
                            }
                        }
                        else
                        {
                            if (picture == 'Y')
                            {
                                price += 40 * numTickets;
                            }
                        }
                    }
                    if (finals == "Final")
                    {
                        price = 160.66 * numTickets;
                        if (price > 4000)
                        {
                            price -= price * 0.25;
                        }
                        else if (price > 2500 && price <= 4000)
                        {
                            price -= price * 0.10;
                            if (picture == 'Y')
                            {
                                price += 40 * numTickets;
                            }
                        }
                        else
                        {
                            if (picture == 'Y')
                            {
                                price += 40 * numTickets;
                            }
                        }
                    }
                    break;
                case "VIP":
                    if (finals == "Quarter final")
                    {
                        price = 118.90 * numTickets;
                        if (price > 4000)
                        {
                            price -= price * 0.25;
                        }
                        else if (price > 2500 && price <= 4000)
                        {
                            price -= price * 0.10;
                            if (picture == 'Y')
                            {
                                price += 40 * numTickets;
                            }
                        }
                        else
                        {
                            if (picture == 'Y')
                            {
                                price += 40 * numTickets;
                            }
                        }
                    }
                    if (finals == "Semi final")
                    {
                        price = 300.40 * numTickets;
                        if (price > 4000)
                        {
                            price -= price * 0.25;
                        }
                        else if (price > 2500 && price <= 4000)
                        {
                            price -= price * 0.10;
                            if (picture == 'Y')
                            {
                                price += 40*numTickets;
                            }
                        }
                        else
                        {
                            if (picture == 'Y')
                            {
                                price += 40 * numTickets;
                            }
                        }
                    }
                    if (finals == "Final")
                    {
                        price = 400 * numTickets;
                        if (price > 4000)
                        {
                            price -= price * 0.25;
                        }
                        else if (price > 2500 && price <= 4000)
                        {
                            price -= price * 0.10;
                            if (picture == 'Y')
                            {
                                price += 40*numTickets;
                            }
                        }
                        else
                        {
                            if (picture=='Y')
                            {
                                price += 40 * numTickets;
                            }                          
                        }
                    }
                    break;
                    
            }
            Console.WriteLine($"{price:F2}");
        }
    }
}
