using System;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
           
            for (int i=num1; i <= num2; i++)
            {
                string currNum = i.ToString();
                int evenSum = 0;
                int oddSum = 0;
                for (int j = 0; j < currNum.Length; j++)
                {
                    if (j%2==0)
                    {
                        evenSum += int.Parse(currNum[j].ToString());
                    }
                    else
                    {
                        oddSum += int.Parse(currNum[j].ToString());
                    }
                }
                if (evenSum==oddSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
