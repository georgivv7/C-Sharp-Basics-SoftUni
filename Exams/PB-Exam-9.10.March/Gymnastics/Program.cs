using System;

namespace Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string instrument = Console.ReadLine();
            double points = 0;
            switch (country)
            {
                case"Russia":
                    if (instrument=="ribbon")
                    {
                        points = 9.100 + 9.400;
                    }
                    else if (instrument=="hoop")
                    {
                        points = 9.300 + 9.800;
                    }
                    else if (instrument=="rope")
                    {
                        points = 9.600 + 9.000;
                    }
                    break;
                case "Bulgaria":
                    if (instrument == "ribbon")
                    {
                        points = 9.600 + 9.400;
                    }
                    else if (instrument == "hoop")
                    {
                        points = 9.550 + 9.750;
                    }
                    else if (instrument == "rope")
                    {
                        points = 9.500 + 9.400;
                    }
                    break;
                case "Italy":
                    if (instrument == "ribbon")
                    {
                        points = 9.200 + 9.500;
                    }
                    else if (instrument == "hoop")
                    {
                        points = 9.450 + 9.350;
                    }
                    else if (instrument == "rope")
                    {
                        points = 9.700 + 9.150;
                    }
                    break;
            }
            double pointsLeft = 20 - points;
            double percent = pointsLeft / 20 * 100;
            Console.WriteLine($"The team of {country} get {points:f3} on {instrument}.");
            Console.WriteLine($"{percent:f2}%");
        }
    }
}
