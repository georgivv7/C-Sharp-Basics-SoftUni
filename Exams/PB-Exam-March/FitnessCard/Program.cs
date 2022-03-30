using System;

namespace FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double price = 0;

            switch (sex)
            {
                case 'm':
                    if (sport == "Gym")
                    {
                        price = 42;
                    }
                    if (sport=="Boxing")
                    {
                        price = 41;
                    }
                    if (sport=="Yoga")
                    {
                        price = 45;
                    }
                    if (sport=="Zumba")
                    {
                        price = 34;
                    }
                    if (sport=="Dances")
                    {
                        price = 51;
                    }
                    if (sport=="Pilates")
                    {
                        price = 39;
                    }
                    break;
                case 'f':
                    if (sport == "Gym")
                    {
                        price = 35;
                    }
                    if (sport == "Boxing")
                    {
                        price = 37;
                    }
                    if (sport == "Yoga")
                    {
                        price = 42;
                    }
                    if (sport == "Zumba")
                    {
                        price = 31;
                    }
                    if (sport == "Dances")
                    {
                        price = 53;
                    }
                    if (sport == "Pilates")
                    {
                        price = 37;
                    }
                    break;
            }
            if (age<=19)
            {
                price -= price * 0.20;
            }
            if (price<=money)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                money = price - money;
                Console.WriteLine($"You don't have enough money! You need ${money:f2} more.");
            }
        }
    }
}
