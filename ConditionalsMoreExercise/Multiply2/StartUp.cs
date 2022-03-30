using System;

namespace Multiply2
{
    class StartUp
    {
        static void Main(string[] args)
        {
            
            double result = 0;
            for (int i = 1; i >0; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if(num < 0)
                {
                    Console.WriteLine("Negative number!");
                }
                while(num>0)
                {
                    result = num * 2;
                    Console.WriteLine($"Result:{result:f2}");
                }
            }

           










        }
    }
}
