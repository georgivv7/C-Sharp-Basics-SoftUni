using System;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double visochinaStena = double.Parse(Console.ReadLine());
            double daljinaStena = double.Parse(Console.ReadLine());
            double visochinaPokriv = double.Parse(Console.ReadLine());

            double stranichnaStena = visochinaStena * daljinaStena;
            double ploshtProzorec = 1.5 * 1.5;
            double DveteStranichniSteni = (2*stranichnaStena)-(2*ploshtProzorec);
            double vhod = 1.2*2;
            double zadnaStena = visochinaStena * visochinaStena;
            double prednaIZadnaStena = (2*zadnaStena)-vhod;
            double obshtaPloshtSteni = DveteStranichniSteni + prednaIZadnaStena;
            double zelenaBoq = obshtaPloshtSteni / 3.4;

            double dveStraniPokriv = stranichnaStena * 2;
            double dveKozirkiPoktiv = 2 * (visochinaStena * visochinaPokriv / 2);
            double obshtaPloshtPokriv = dveStraniPokriv + dveKozirkiPoktiv;
            double chervenaBoq = obshtaPloshtPokriv / 4.3;

            Console.WriteLine($"{zelenaBoq:f2}");
            Console.WriteLine($"{chervenaBoq:f2}");
           
            

        }
    }
}
