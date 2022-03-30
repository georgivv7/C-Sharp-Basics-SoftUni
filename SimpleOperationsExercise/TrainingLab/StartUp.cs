using System;

namespace TrainingLab
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double daljina = double.Parse(Console.ReadLine());
            double shirina = double.Parse(Console.ReadLine());

            double koloni = (shirina-1)*100;
            double redoveLqvo = Math.Truncate(koloni / 70);
            double redoveDqsno =Math.Truncate((daljina*100) / 120);
            double broiMesta = (redoveLqvo * redoveDqsno) - 3;

            Console.WriteLine(broiMesta);
        }
    }
}
