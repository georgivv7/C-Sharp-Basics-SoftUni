using System;

namespace InchtoCentimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            double centToInch = 2.54;
            double realNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(centToInch*realNumber);
        }
    }
}
