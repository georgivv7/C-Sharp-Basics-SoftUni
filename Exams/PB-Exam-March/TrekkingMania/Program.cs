using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfGroups = int.Parse(Console.ReadLine());
            double sum = 0;
            double musala = 0;
            double monblan = 0;
            double kilimandgaro = 0;
            double k2 = 0;
            double everest = 0;
            for (int i = 1; i <=numOfGroups; i++)
            {
                int numOfPeople = int.Parse(Console.ReadLine());
                sum += numOfPeople;
                if (numOfPeople<=5)
                {
                    musala += numOfPeople; 
                }
                if (numOfPeople>=6&&numOfPeople<=12)
                {
                    monblan += numOfPeople; 
                }
                if (numOfPeople>=13&&numOfPeople<=25)
                {
                    kilimandgaro += numOfPeople;
                }
                if (numOfPeople>=26&&numOfPeople<=40)
                {
                    k2 += numOfPeople;
                }
                if (numOfPeople>=41)
                {
                    everest += numOfPeople; 
                }
            }
            double percentMusala = (musala / sum) * 100;
            double percentMonblan = (monblan / sum) * 100;
            double percentKilimandgaro = (kilimandgaro / sum) * 100;
            double percentK2 = (k2 / sum) * 100;
            double percentEverest = (everest / sum) * 100;
            Console.WriteLine($"{percentMusala:f2}%");
            Console.WriteLine($"{percentMonblan:f2}%");
            Console.WriteLine($"{percentKilimandgaro:f2}%");
            Console.WriteLine($"{percentK2:f2}%");
            Console.WriteLine($"{percentEverest:f2}%");
        }
    }
}
