using System;

namespace Time_15Minutse
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            
            if (minutes>=45)
            {
                hours += 1;
                minutes +=15 - 60;
            }
            else
            {
                minutes += 15;
            }

            if (hours==24)
            {
                hours = 0;     
            }
            
            Console.WriteLine($"{hours}:{minutes:D2}");
            
           
             
        }
    }
}
