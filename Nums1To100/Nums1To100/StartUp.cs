using System;

namespace Nums1To100
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <=num; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
