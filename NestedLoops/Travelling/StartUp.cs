using System;

namespace Travelling
{
    class StartUp
    {
        static void Main(string[] args)
        {

            string destination = Console.ReadLine();
            
            while (destination != "End")
            {
                double sum = 0;                                        
                double price = double.Parse(Console.ReadLine());

                while (sum < price)
                {
                    double deposit = double.Parse(Console.ReadLine());
                    sum += deposit;                                
                }
                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}
