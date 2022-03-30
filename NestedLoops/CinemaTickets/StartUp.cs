using System;

namespace CinemaTickets
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int totalSeats = 0;
            int standardTicket = 0;
            int studentTicket = 0;
            int kidsTicket = 0;
            while (movie!="Finish")
            {
                int seatsAvalable = int.Parse(Console.ReadLine());
                string ticket = Console.ReadLine();
                int currentSeats = 0;
                
                while (ticket!="End")
                {
                    currentSeats++;
                    
                    switch (ticket)
                    {
                        case "standard":
                            standardTicket++;
                            break;
                        case "student":
                            studentTicket++;
                            break;
                        case "kid":
                            kidsTicket++;
                            break;
                        
                    }
                    if (seatsAvalable==currentSeats)
                    {
                        break;
                    }
                    ticket = Console.ReadLine();
                    
                }
                double moviePercent = currentSeats * 1.0 / seatsAvalable * 100;
                Console.WriteLine($"{movie} - {moviePercent:f2}% full.");
                totalSeats += currentSeats;
                movie = Console.ReadLine();
            }
            
            double percentStandard = standardTicket * 1.0 / totalSeats* 100;
            double percentStudent = studentTicket * 1.0 / totalSeats* 100;
            double percentKids = kidsTicket * 1.0 / totalSeats * 100;
            Console.WriteLine($"Total tickets: {totalSeats}");
            Console.WriteLine($"{percentStudent:f2}% student tickets.");
            Console.WriteLine($"{percentStandard:f2}% standard tickets.");
            Console.WriteLine($"{percentKids:f2}% kids tickets.");
        }
    }
}
