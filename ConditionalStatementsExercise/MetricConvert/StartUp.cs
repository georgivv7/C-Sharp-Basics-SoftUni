using System;

namespace MetricConvert
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string measureIn = Console.ReadLine();
            string measureOut = Console.ReadLine();

            double finalNumber = 0;
            if (measureIn=="mm"&&measureOut=="m")
            {
                finalNumber = number / 1000;
            }
            else if (measureIn=="mm"&&measureOut=="cm")
            {
                finalNumber = number / 10;
            }
            else if (measureIn=="cm"&&measureOut=="mm")
            {
                finalNumber = number * 10;
            }
            else if (measureIn=="m"&&measureOut=="cm")
            {
                finalNumber = number * 100;
            }
            else if (measureIn=="m"&&measureOut=="mm")
            {
                finalNumber = number * 1000;
            }
            else if (measureIn=="cm"&&measureOut=="m")
            {
                finalNumber = number / 100;
            }
            Console.WriteLine($"{finalNumber:f3}");

            
        }
    }
}
