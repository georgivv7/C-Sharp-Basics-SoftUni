using System;

namespace _04.CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
            double voucher = double.Parse(Console.ReadLine());
            string input =Console.ReadLine();
            int tickets = 0;
            int others = 0;
            double price = 0;
            while (true)
            {
                if (input=="End")
                {
                    break;
                }              
                if (input.Length>8)
                {
                    
                    price = input[0] + input[1];
                    if (price > voucher)
                    {
                        break;
                    }
                    tickets++;

                }
                else if (input.Length<=8)
                {                  
                    price = input[0];
                    if (price > voucher)
                    {
                        break;
                    }
                    others++;
                }                                             
                voucher -= price;
                input =Console.ReadLine();
            }
            Console.WriteLine($"{tickets}");
            Console.WriteLine($"{others}");
        }
    }
}
