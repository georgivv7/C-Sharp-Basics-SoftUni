using System;

namespace CoffeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numOfDrinks = int.Parse(Console.ReadLine());

            double price = 0;
            double discount = 0;
            switch (sugar)
            {
                case"Without":
                    discount = 0.35;
                    if (drink=="Espresso")
                    {
                        price = 0.90 * numOfDrinks;
                        price -= price * discount;
                        if (numOfDrinks>=5)
                        {
                            price -= price * 0.25; 
                        }                     
                    }
                    else if (drink=="Cappuccino")
                    {
                        price = 1 * numOfDrinks;
                        price -= price * discount;                      
                    }
                    else if (drink=="Tea")
                    {
                        price = 0.50 * numOfDrinks;
                        price -= price * discount;                       
                    }
                    break;
                case "Normal":
                    if (drink=="Espresso")
                    {
                        price = 1 * numOfDrinks;
                        if (numOfDrinks>=5)
                        {
                            price -= price * 0.25;
                        }
                    }
                    else if (drink=="Cappuccino")
                    {
                        price = 1.20 * numOfDrinks;                       
                    }
                    else if (drink == "Tea")
                    {
                        price = 0.60 * numOfDrinks;                     
                    }
                    break;
                case "Extra":
                    if (drink == "Espresso")
                    {
                        price = 1.20 * numOfDrinks;
                        if (numOfDrinks >= 5)
                        {
                            price -= price * 0.25;
                        }
                    }
                    else if (drink == "Cappuccino")
                    {
                        price = 1.60 * numOfDrinks;                       
                    }
                    else if (drink == "Tea")
                    {
                        price = 0.70 * numOfDrinks;                      
                    }
                    break;
            }
            if (price > 15)
            {
                price -= price * 0.20;
            }
            Console.WriteLine($"You bought {numOfDrinks} cups of {drink} for {price:f2} lv.");
        }
    }
}
