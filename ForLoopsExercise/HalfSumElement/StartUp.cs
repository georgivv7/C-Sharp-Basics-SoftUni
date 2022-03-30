using System;

namespace HalfSumElement
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int sum = 0;

            for (int i = 1; i <= counter; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num>maxNum)
                {
                    maxNum = num;
                    sum += num;                                        
                }
                else
                {
                    sum += num;
                }
            }
            sum = sum - maxNum;
            if (sum==maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum-maxNum)}");
            }
            
        }
    }
}
