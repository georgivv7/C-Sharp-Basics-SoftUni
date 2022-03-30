using System;

namespace HotelRoom
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double numOfNights = double.Parse(Console.ReadLine());

            
            double totalPriceS = 0.00;
            double totalPriceA = 0.00;

            if (month=="May"||month=="October")
            {
                totalPriceS = 50 * numOfNights;
                totalPriceA = 65 * numOfNights;

                if (numOfNights>7&&numOfNights<=14)
                {  
                    totalPriceS = totalPriceS*0.95;
                    
                }
                else if (numOfNights>14)
                {                    
                    totalPriceS = totalPriceS * 0.70;                 
                    totalPriceA = totalPriceA*0.90;
                }
            }
            else if (month=="June"||month=="September")
            {           
                    totalPriceS = 75.20 * numOfNights;                                     
                    totalPriceA = 68.70 * numOfNights;
                
                if (numOfNights > 14)
                {
                    totalPriceS = totalPriceS*0.80;
                    totalPriceA = totalPriceA*0.90;
                }
            }
            else if (month=="July"||month=="August")
            {              
                    totalPriceS = 76 * numOfNights;
                    totalPriceA = 77 * numOfNights;
                
                if (numOfNights > 14)
                {
                    totalPriceS = 76 * numOfNights;                    
                    totalPriceA = totalPriceA*0.90;
                }
            }
            Console.WriteLine($"Apartment: {totalPriceA:f2} lv.");
            Console.WriteLine($"Studio: {totalPriceS:f2} lv.");
        }
    }
}
