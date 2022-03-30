using System;

namespace Password
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string passInput = Console.ReadLine();
            while (passInput!=password)
            {  
                passInput =Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");


        }
    }
}
