using System;

namespace _06.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            double total = 0;
            double currTickets = 0;
            double standardTickets = 0;
            double studentTickets = 0;
            double kidTickets = 0;
            while (true)
            {
                currTickets = 0;
                if (movie=="Finish")
                {
                    break;
                }
                double seatsAvailale = double.Parse(Console.ReadLine());               
                while (seatsAvailale != currTickets)
                {
                    string type = Console.ReadLine();
                    if (type=="End")
                    {
                        break;
                    }
                    switch (type)
                    {
                        case "standard":
                            standardTickets++;
                            currTickets++;
                            break;
                        case "student":
                            studentTickets++;
                            currTickets++;
                            break;
                        case "kid":
                            kidTickets++;
                            currTickets++;
                            break;

                    }
                }
                double percentMovie = currTickets / seatsAvailale * 100;
                Console.WriteLine($"{movie} - {percentMovie:f2}% full.");
                movie = Console.ReadLine();
            }
            total = standardTickets + studentTickets + kidTickets;
            double percentStudent = studentTickets / total * 100;
            double percentStandard = standardTickets / total * 100;
            double percentKid = kidTickets / total * 100;
            if (movie=="Finish")
            {
                Console.WriteLine($"Total tickets: {total}");
                Console.WriteLine($"{percentStudent:F2}% student tickets.");
                Console.WriteLine($"{percentStandard:F2}% standard tickets.");
                Console.WriteLine($"{percentKid:F2}% kids tickets.");
            }
            
        }
    }
}
