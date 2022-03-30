using System;

namespace OldLibrary
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();
            int bookCounter = 0;

            while (true)
            {
                string book = Console.ReadLine();              
                if (favBook == book)
                {
                    Console.WriteLine($"You checked {bookCounter} books and found it.");
                    break;
                }
                              
                if(book=="No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {bookCounter} books.");
                    break;
                }
                bookCounter++;

            }
        }
    }
}
