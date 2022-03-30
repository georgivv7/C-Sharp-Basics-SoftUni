using System;

namespace HappyCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDays = int.Parse(Console.ReadLine());
            int numOfHours = int.Parse(Console.ReadLine());
            double parkingPrice = 0;
            double totalPrice = 0;

            for (int days = 1; days <= numOfDays; days++)
            {
                for (int hours = 1; hours <= numOfHours; hours++)
                {
                    if (days%2==0&&hours%2!=0)
                    {
                        parkingPrice += 2.50;
                    }
                    else if (days%2!=0&&hours%2==0)
                    {
                        parkingPrice += 1.25;
                    }
                    else
                    {
                        parkingPrice += 1.00;
                    }
                    
                }
                totalPrice += parkingPrice;
                Console.WriteLine($"Day: {days} - {parkingPrice:F2} leva");
                parkingPrice = 0;
            }
            
            Console.WriteLine($"Total: {totalPrice:F2} leva");
        }
    }
}
