using System;

namespace _03.OscarsWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie =Console.ReadLine();
            string type =Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            double income = 0;
            switch (movie)
            {
                case"A Star Is Born":
                    if (type=="normal")
                    {
                        income = 7.50 * tickets;
                    }
                    else if (type=="luxury")
                    {
                        income = 10.50 * tickets;
                    }
                    else if (type=="ultra luxury")
                    {
                        income = 13.50 * tickets;
                    }
                    break;
                case "Bohemian Rhapsody":
                    if (type == "normal")
                    {
                        income = 7.35 * tickets;
                    }
                    else if (type == "luxury")
                    {
                        income = 9.45 * tickets;
                    }
                    else if (type == "ultra luxury")
                    {
                        income = 12.75 * tickets;
                    }
                    break;
                case "Green Book":
                    if (type == "normal")
                    {
                        income = 8.15 * tickets;
                    }
                    else if (type == "luxury")
                    {
                        income = 10.25 * tickets;
                    }
                    else if (type == "ultra luxury")
                    {
                        income = 13.25 * tickets;
                    }
                    break;
                case "The Favourite":
                    if (type == "normal")
                    {
                        income = 8.75 * tickets;
                    }
                    else if (type == "luxury")
                    {
                        income = 11.55 * tickets;
                    }
                    else if (type == "ultra luxury")
                    {
                        income = 13.95 * tickets;
                    }
                    break;
            }
            Console.WriteLine($"{movie} -> {income:f2} lv.");
        }
    }
}
