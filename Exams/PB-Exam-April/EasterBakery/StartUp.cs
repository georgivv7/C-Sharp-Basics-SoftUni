using System;

namespace EasterBakery
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numOfClients = int.Parse(Console.ReadLine());
            string input = string.Empty;
            double bill = 0;
            int counter = 0;
            double totalBill = 0;
            for (int i = 1; i <= numOfClients; i++)
            {
                bill=0;
                counter = 0;
                while (true)
                {                   
                    input = Console.ReadLine();                
                    if (input=="Finish")
                    {
                        if (counter % 2 == 0)
                        {
                            bill = bill - bill * 0.20;
                        }
                        totalBill += bill;
                        Console.WriteLine($"You purchased {counter} items for {bill:f2} leva.");
                        break;
                    }
                    switch (input)
                    {
                        case "basket":
                            bill += 1.50;
;                            break;
                        case "wreath":
                            bill += 3.80;
                            break;
                        case "chocolate bunny":
                            bill += 7;
                            break;
                    }
                    counter++;                  
                    
                }                                
            }
            totalBill = totalBill / numOfClients;
            Console.WriteLine($"Average bill per client is: {totalBill:f2} leva.");
        }
    }
}
