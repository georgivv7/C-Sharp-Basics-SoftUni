using System;

namespace TrasportPrice
{
    class StartUp
    {
        static void Main(string[] args)
        {
          
            int distance = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double price = 0;
            if (distance<20&&dayOrNight=="day")
            {
                price = 0.70 + distance * 0.79;
            }
            else if (distance<20&&dayOrNight=="night")
            {
                price = 0.70 + distance * 0.90;
            }
            if (distance>=20&&distance<100)
            {
                price = 0.09 * distance;
                
            }
            else if(distance>=100)
            {
                price = distance * 0.06;
            }
            Console.WriteLine($"{price:f2}");


        }
    }
}
