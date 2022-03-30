using System;

namespace Sequence2K_1
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //read number
            int n = int.Parse(Console.ReadLine());
            int k = 1;

            while (k<=n)
            {
                Console.WriteLine(k);
                k = 2 * k + 1;
            }

           
        }
    }
}
