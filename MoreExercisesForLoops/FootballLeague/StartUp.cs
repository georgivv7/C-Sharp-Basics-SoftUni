using System;

namespace FootballLeague
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double stadiumCapacity = double.Parse(Console.ReadLine());
            double numOfFans = double.Parse(Console.ReadLine());
            double sumA = 0;
            double sumB = 0;
            double sumG = 0;
            double sumV = 0;
            for (int i = 1; i <= numOfFans; i++)
            {
                string sector = Console.ReadLine();
                if (sector=="A")
                {
                    sumA += 1;
                }
                if (sector=="B")
                {
                    sumB += 1;
                }
                if (sector=="G")
                {
                    sumG += 1;
                }
                if (sector=="V")
                {
                    sumV += 1;
                }
            }
            double percentA = (sumA / numOfFans) * 100;
            double percentB = (sumB / numOfFans) * 100;
            double percentG = (sumG / numOfFans) * 100;
            double percentV = (sumV / numOfFans) * 100;
            double percentCapacity = (numOfFans/stadiumCapacity) * 100;
            Console.WriteLine($"{percentA:f2}%");
            Console.WriteLine($"{percentB:f2}%");
            Console.WriteLine($"{percentV:f2}%");
            Console.WriteLine($"{percentG:f2}%");
            Console.WriteLine($"{percentCapacity:f2}%");
        }
    }
}
