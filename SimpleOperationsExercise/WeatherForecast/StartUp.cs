using System;

namespace WeatherForecast
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           

            if (input=="sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else if (input=="cloudy")
            {
                Console.WriteLine("It's cold outside!");
            }
            else if (input=="snowy")
            {
                Console.WriteLine("It's cold outside!");
            }
        }   
    }
}
