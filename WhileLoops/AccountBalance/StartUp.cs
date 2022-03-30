using System;

namespace AccountBalance
{
    class StartUp
    {
        static void Main(string[] args)
        {           
            string input =Console.ReadLine();
            double sum = 0;
            while (input!="NoMoreMoney")
            {
                double payment = double.Parse(input);
                
                if (payment < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += payment;
                Console.WriteLine($"Increase: {payment:f2}");                                            
                input =Console.ReadLine();                
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
