using System;

namespace Volleyball
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string typeOfYear = Console.ReadLine();
            double numOFHolidays = double.Parse(Console.ReadLine());
            double weekendsInVillage = double.Parse(Console.ReadLine());

            double weekendsInSofia = (48 - weekendsInVillage)*3/4;
            double sumWeekends = weekendsInSofia + weekendsInVillage;
            double sumHolidays = (numOFHolidays) * 2 / 3;
            double totalDaysLeap = 0;
            double additionalGames = 0;
            double totalDays = sumHolidays + sumWeekends;

            if (typeOfYear =="leap")
            {
                additionalGames = totalDays * 0.15;
                totalDaysLeap = totalDays + additionalGames;
                Console.WriteLine(Math.Floor(totalDaysLeap));

            }
            else
            {
                Console.WriteLine(Math.Floor(totalDays));
            }
        }
    }
}
