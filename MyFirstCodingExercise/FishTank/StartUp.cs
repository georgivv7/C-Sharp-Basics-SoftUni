using System;

namespace FishTank
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int obemAkvarium = lenght * width * height;
            double obshtoLitri = obemAkvarium * 0.001;
            double procent = percent * 0.01;
            double OstavashtiLitri = obshtoLitri * (1-procent);

            Console.WriteLine(OstavashtiLitri);
        }
    }
}
