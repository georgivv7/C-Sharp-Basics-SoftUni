using System;

namespace FuelTank2
{
    class Program
    {
        static void Main(string[] args)
        {

            const double petrolPrice = 2.22;
            const double dieselPrice = 2.33;
            const double gasPrice = 0.93;

            string typeOfFuel = Console.ReadLine();
            double LitresFuel = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            double discount = 0;
            double Price = 0;
            double lastPrice = 0;

            if (typeOfFuel == "Gas" && clubCard == "Yes"||clubCard=="No")
            {
                if (LitresFuel >= 20 && LitresFuel <= 25)
                {
                    discount = gasPrice - 0.08;
                    Price = (LitresFuel * discount);
                    lastPrice = Price - (Price * 0.08);
                    Console.WriteLine($"{lastPrice:f2}");

                }
                else if (LitresFuel > 25)
                {
                    discount = gasPrice - 0.08;
                    Price = (LitresFuel * discount);
                    lastPrice = Price - (Price * 0.10);
                    Console.WriteLine($"{lastPrice:f2}");
                }
                else if(LitresFuel < 20)
                {
                    Price = gasPrice * LitresFuel;
                    Console.WriteLine($"{Price:f2}");
                }
            }
            if (typeOfFuel == "Gasoline" && clubCard == "Yes"|| clubCard=="No")
            {
                if (LitresFuel >= 20 && LitresFuel <= 25)
                {
                    discount = petrolPrice - 0.18;
                    Price = (LitresFuel * discount);
                    lastPrice = Price - (Price * 0.08);
                    Console.WriteLine($"{lastPrice:f2}");

                }
                else if (LitresFuel > 25)
                {
                    discount = petrolPrice - 0.18;
                    Price = (LitresFuel * discount);
                    lastPrice = Price - (Price * 0.10);
                    Console.WriteLine($"{lastPrice:f2}");
                }
                else if (LitresFuel < 20)
                {
                    Price = petrolPrice * LitresFuel;
                    Console.WriteLine($"{Price:f2}");
                }
                
            }

            if (typeOfFuel == "Diesel" && clubCard == "Yes" || clubCard=="No")
            {

                if (LitresFuel >= 20 && LitresFuel <= 25)
                {
                    discount = dieselPrice - 0.12;
                    Price = (LitresFuel * discount);
                    lastPrice = Price - (Price * 0.08);
                    Console.WriteLine($"{lastPrice:f2}");

                }
                else if (LitresFuel > 25)
                {
                    discount = dieselPrice - 0.12;
                    Price = (LitresFuel * discount);
                    lastPrice = Price - (Price * 0.10);
                    Console.WriteLine($"{lastPrice:f2}");
                }
                else if(LitresFuel<20)
                {
                    Price = dieselPrice * LitresFuel;
                    Console.WriteLine($"{Price:f2}");
                }













            }
        }
    }
}
