using System;

namespace NumberPyramid
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currNum = 1;
            bool isBigger = false;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int col = 1; col <=rows; col++)
                {
                    if (currNum>n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(currNum + " ");
                    currNum++;
                }              
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
            
        }
    }
}
