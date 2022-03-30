using System;

namespace BookList
{
    class StartUp

    {
        static void Main(string[] args)
        {
            int PagesInBook = int.Parse(Console.ReadLine());
            double PagesPerHour = double.Parse(Console.ReadLine());
            int DaysForBook = int.Parse(Console.ReadLine());

            double HoursForBook = PagesInBook / PagesPerHour;
            double HoursPerDay = HoursForBook / DaysForBook;

            Console.WriteLine(HoursPerDay);
        }
    }
}
