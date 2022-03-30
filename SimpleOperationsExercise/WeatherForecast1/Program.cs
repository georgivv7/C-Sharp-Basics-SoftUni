using System;

namespace WeatherForecast1
{
    class Program
    {
        static void Main(string[] args)
        {
            var weather = Console.ReadLine();

            if (weather=="sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else 
            {
                Console.WriteLine("It's cold outside!");
            }
           
            
        }
    }
}
