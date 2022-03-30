using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodForDogs = 2.50;
            double foodForOthers = 4.00;
            int numOfDogs = int.Parse(Console.ReadLine());
            int numOthers = int.Parse(Console.ReadLine());
            double finalPrice1 = foodForDogs * numOfDogs;
            double finalPrice2 = foodForOthers * numOthers;
            double sumFinalprice = finalPrice1 + finalPrice2;
            Console.WriteLine($"{sumFinalprice} lv.");
           

        }
    }
}
