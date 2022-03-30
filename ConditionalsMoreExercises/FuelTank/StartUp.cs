using System;

namespace FuelTank
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string typeOfFuel = Console.ReadLine();
            double Litres = double.Parse(Console.ReadLine());

            typeOfFuel = typeOfFuel.ToLower();
            if (typeOfFuel == "Diesel"||typeOfFuel=="diesel") 
            {
                if (Litres >= 25)
                {
                    Console.WriteLine($"You have enough {typeOfFuel}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {typeOfFuel}!");
                }
 
            }

            else if (typeOfFuel == "Gasoline"||typeOfFuel=="gasoline")
            {
                if (Litres >= 25)
                {
                    Console.WriteLine($"You have enough {typeOfFuel}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {typeOfFuel}!");
                }
                
            }
            else if (typeOfFuel == "Gas"||typeOfFuel=="gas")
            {
                if (Litres >= 25)
                {
                    Console.WriteLine($"You have enough {typeOfFuel}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {typeOfFuel}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
