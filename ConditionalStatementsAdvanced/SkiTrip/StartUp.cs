using System;

namespace SkiTrip
{
    class StartUp
    {
        static void Main(string[] args)
        {
            const double forOne = 18.00;
            const double forApart = 25.00;
            const double forPresident = 35.00;

            int days = int.Parse(Console.ReadLine());
            string typeOfPlace = Console.ReadLine();
            string opinion = Console.ReadLine();

            double nights = days - 1;
            double price = 0;
            double totalPrice = 0;
            double discount = 0;
            

            if (typeOfPlace=="room for one person")
            {
                if (opinion=="positive")
                {
                    price = nights * forOne;
                    totalPrice = price + price * 0.25;
                }
                else if (opinion=="negative")
                {
                    price = nights * forOne;
                    totalPrice = price - price * 0.10;
                }
                
            }
            else if (typeOfPlace=="apartment")
            {
                if (opinion=="positive")
                {
                    if (days<10)
                    {
                        price = nights * forApart;
                        discount = price- price * 0.25;
                        totalPrice = discount+ discount* 0.25;
                    }
                    else if (days>=10&&days<=15)
                    {
                        price = nights * forApart;
                        discount = price - price * 0.35;
                        totalPrice = discount + discount * 0.25;
                    }
                    else if(days>15)
                    {
                        price = nights * forApart;
                        discount = price - price * 0.50;
                        totalPrice = discount + discount * 0.25;
                    }  
                }
                else if (opinion=="negative")
                {
                    if (days < 10)
                    {
                        price = nights * forApart;
                        discount = price - price * 0.30;
                        totalPrice = discount - discount * 0.1;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price = nights * forApart;
                        discount = price - price * 0.35;
                        totalPrice = discount - discount * 0.1;
                    }
                    else if(days>15)
                    {
                        price = nights * forApart;
                        discount = price - price * 0.50;
                        totalPrice = discount - discount * 0.1;
                    }

                }
            }
            else if (typeOfPlace=="president apartment")
            {
                if (opinion=="positive")
                {
                    if (days < 10)
                    {
                        price = nights * forPresident;
                        discount = price - price * 0.10;
                        totalPrice = discount + discount * 0.25;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price = nights * forPresident;
                        discount = price - price * 0.15;
                        totalPrice = discount + discount* 0.25;
                    }
                    else if(days>15)
                    {
                        price = nights * forPresident;
                        discount = price - price * 0.20;
                        totalPrice = discount + discount * 0.25;
                    }

                }
                else if (opinion=="negative")
                {
                    if (days < 10)
                    {
                        price = nights * forPresident;
                        discount = price - price * 0.10;
                        totalPrice = discount - discount * 0.1;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price = nights * forPresident;
                        discount = price - price * 0.15;
                        totalPrice = discount - discount * 0.10;
                    }
                    else if(days>15)
                    {
                        price = nights * forPresident;
                        discount = price - price * 0.20;
                        totalPrice = discount - discount * 0.10;
                    }
                }
            }

            Console.WriteLine($"{totalPrice:f2}");
                
        }
    }
}
