using System;

namespace MatchTicket
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numOfPeople = int.Parse(Console.ReadLine());

            double price = 0;
            double forTransport = 0;
            double difference = 0;

            if (category=="VIP")
            {
                if (numOfPeople >= 1 && numOfPeople <= 4)
                {
                    forTransport = 0.75 * budget;
                    difference = budget - forTransport;
                    price = numOfPeople*499.99;
                }
                else if (numOfPeople >= 5 && numOfPeople <= 9)
                {
                    forTransport = 0.60 * budget;
                    difference = budget - forTransport;
                    price = numOfPeople* 499.99;
                }
                else if (numOfPeople >= 10 && numOfPeople <= 24)
                {
                    forTransport = 0.50 * budget;
                    difference = budget - forTransport;
                    price = numOfPeople* 499.99;
                }
                else if (numOfPeople >= 25 && numOfPeople <= 49)
                {
                    forTransport = 0.40 * budget;
                    difference = budget - forTransport;
                    price = numOfPeople* 499.99;
                }
                else if (numOfPeople >= 50)
                {
                    forTransport = 0.25 * budget;
                    difference = budget - forTransport;
                    price = numOfPeople* 499.99;
                }
            }
            else if (category=="Normal")
            {
                if (numOfPeople >= 1 && numOfPeople <= 4)
                {
                    forTransport = 0.75 * budget;
                    difference = budget - forTransport;
                    price = numOfPeople * 249.99;
                }
                else if (numOfPeople >= 5 && numOfPeople <= 9)
                {
                    forTransport = 0.60 * budget;
                    difference = budget - forTransport;
                    price = numOfPeople * 249.99;
                }
                else if (numOfPeople >= 10 && numOfPeople <= 24)
                {
                    forTransport = 0.50 * budget;
                    difference = budget - forTransport;
                    price = numOfPeople * 249.99;
                }
                else if (numOfPeople >= 25 && numOfPeople <= 49)
                {
                    forTransport = 0.40 * budget;
                    difference = budget - forTransport;
                    price = numOfPeople * 249.99;
                }
                else if (numOfPeople >= 50)
                {
                    forTransport = 0.25 * budget;
                    difference = budget - forTransport;
                    price = numOfPeople * 249.99;
                }
            }
            
            if (price>difference)
            {
                Console.WriteLine($"Not enough money! You need {price - difference:f2} leva.");
            }
            else
            {
                Console.WriteLine($"Yes! You have {difference - price:f2} leva left.");
            }
        }
    }
    
}
