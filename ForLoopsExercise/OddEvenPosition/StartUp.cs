using System;

namespace OddEvenPosition
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            double OddSum = 0;
            double OddMin = int.MaxValue;
            double OddMax = int.MinValue;
            double EvenSum = 0;
            double EvenMin = int.MaxValue;
            double EvenMax = int.MinValue;

            for (int i = 0; i < counter; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    OddSum += num;
                    if (num>OddMax)
                    {
                        OddMax = num;
                        
                    }
                    if(num<OddMin)
                    {
                        OddMin = num;
                    }
                }
                else 
                {
                    EvenSum += num;
                    if (num>EvenMax)
                    {
                        EvenMax = num;
                    }
                    if(num<EvenMin)
                    {
                        EvenMin = num;
                    }
                }
                
                
            }
            if (counter == 0)
            {
                Console.WriteLine($"OddSum={OddSum:f2},");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine($"EvenSum={EvenSum:f2},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");

            }
            else if (OddSum == 0)
            { 

                Console.WriteLine($"OddSum={OddSum:f2},");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine($"EvenSum={EvenSum:f2},");
                Console.WriteLine($"EvenMin={EvenMin:f2},");
                Console.WriteLine($"EvenMax={EvenMax:f2}");
            }
            else if (EvenSum==0)
            {
                Console.WriteLine($"OddSum={OddSum:f2},");
                Console.WriteLine($"OddMin={OddMin:f2},");
                Console.WriteLine($"OddMax={OddMax:f2},");
                Console.WriteLine($"EvenSum={EvenSum:f2},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            
            else
            {
                Console.WriteLine($"OddSum={OddSum:f2},");
                Console.WriteLine($"OddMin={OddMin:f2},");
                Console.WriteLine($"OddMax={OddMax:f2},");
                Console.WriteLine($"EvenSum={EvenSum:f2},");
                Console.WriteLine($"EvenMin={EvenMin:f2},");
                Console.WriteLine($"EvenMax={EvenMax:f2}");
            }

        }
    }
}
