using System;

namespace ReportSystem
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            string command = string.Empty;
            int number1 = 0;
            int number2 = 0;
            double sum = 0;
            int counter = 1;
            double sumCash = 0;
            double sumCard = 0;

            while (sum<target)
            {
                command = Console.ReadLine();
                counter++;                                        
                if (command == "End")
                {                   
                    break;
                }
                int productPrice = int.Parse(command);
                if (counter%2==0&&productPrice<=100)
                {
                    number1++;
                    sumCash += productPrice;
                    sum += productPrice;
                    Console.WriteLine("Product sold!");
                    continue;

                }
                if (counter%2==1&&productPrice>10)
                {
                    number2++;
                    sumCard += productPrice;
                    sum += productPrice;
                    Console.WriteLine("Product sold!");
                    continue;
                }
                else
                {
                    Console.WriteLine("Error in transaction!");
                    continue;
                }
                
            }
            if (sum >= target)
            {
                Console.WriteLine($"Average CS: {sumCash / number1:f2}");
                Console.WriteLine($"Average CC: {sumCard / number2:f2}");
            }
            else
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
            



        }
    }
}
