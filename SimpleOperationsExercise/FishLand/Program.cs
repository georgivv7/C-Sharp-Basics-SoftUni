using System;

namespace FishLand
{
    class Program
    {
        static void Main(string[] args)
        {
            const double cenaMidi = 7.50;
          
            double cenaSkumria = double.Parse(Console.ReadLine());
            double cenaCaca = double.Parse(Console.ReadLine());
            double kgPalamud = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            int kgMidi = int.Parse(Console.ReadLine());

            double cenaPalamud = cenaSkumria + (cenaSkumria * 0.6);
            double cenaSafrid = cenaCaca + (cenaCaca * 0.8);
            double sumPalamud = cenaPalamud * kgPalamud;
            double sumSafrid = cenaSafrid * kgSafrid;
            double sumMidi = cenaMidi * kgMidi;
            double smetka = sumPalamud + sumSafrid + sumMidi;

            Console.WriteLine($"{smetka:f2}");
            


        }
    }
}
