using System;

namespace PcGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOfGames = double.Parse(Console.ReadLine());
            double percentHearthstone = 0;
            double percentFornite = 0;
            double percentOverwatch = 0;
            double percentOthers = 0;
            double counterHearthstone = 0;
            double counterFortnite = 0;
            double counterOverwatch = 0;
            double counterOthers = 0;
            for (int i = 1; i <= numOfGames; i++)
            {
                string nameOfGame = Console.ReadLine();
                if (nameOfGame=="Hearthstone")
                {
                    counterHearthstone++;
                    percentHearthstone = (100/numOfGames)*counterHearthstone; 
                }
                else if (nameOfGame=="Fornite")
                {
                    counterFortnite++;
                    percentFornite = (100 / numOfGames)*counterFortnite;
                }
                else if (nameOfGame=="Overwatch")
                {
                    counterOverwatch++;
                    percentOverwatch = (100 / numOfGames)*counterOverwatch;
                }
                else if (nameOfGame!="Overwatch"&&nameOfGame!="Fortnite"&&nameOfGame!="Hearthstone")
                {
                    counterOthers++;
                    percentOthers = (100 / numOfGames)*counterOthers;
                }
            }
            Console.WriteLine($"Hearthstone - {percentHearthstone:f2}%");
            Console.WriteLine($"Fornite - {percentFornite:f2}%");
            Console.WriteLine($"Overwatch - {percentOverwatch:f2}%");
            Console.WriteLine($"Others - {percentOthers:f2}%");

        }
    }
}
