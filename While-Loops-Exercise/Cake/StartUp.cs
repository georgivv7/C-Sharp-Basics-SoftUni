using System;

namespace Cake
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int sumPieces = 0;
            int cacke = height * lenght; ;
            while (sumPieces <= cacke)
            {
                string command = Console.ReadLine();          
                if (command == "STOP")
                {
                    break;
                }       
                int pieces = int.Parse(command);
                sumPieces += pieces;

            }
            if (sumPieces <= cacke)
            {
                cacke -= sumPieces;
                Console.WriteLine($"{cacke} pieces are left.");

            }
            else
            {
                sumPieces = sumPieces - cacke;
                Console.WriteLine($"No more cake left! You need {sumPieces} pieces more.");
            }
        }
    }
}
