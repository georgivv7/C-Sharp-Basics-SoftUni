using System;

namespace _04.Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string input = string.Empty;
            int currentPoints = 301;
            int shotsSuccess = 0;
            int shotsUnsuccess = 0;
            while (true)
            {
                input = Console.ReadLine();
                if (input=="Retire")
                {
                    Console.WriteLine($"{name} retired after {shotsUnsuccess} unsuccessful shots.");
                    break;
                }
                int points = int.Parse(Console.ReadLine());
                
                switch (input)
                {
                    case"Single":
                        points *= 1;
                        if (points > currentPoints)
                        {
                            shotsUnsuccess++;
                            continue;
                        }                   
                        if(points<=currentPoints)
                        {
                            shotsSuccess++;
                            currentPoints -= points;
                        }                        
                        break;
                    case "Double":
                        points *= 2;
                        if (points > currentPoints)
                        {
                            shotsUnsuccess++;
                            continue;
                        }                    
                        if(points<=currentPoints)
                        {
                            shotsSuccess++;                     
                            currentPoints -= points;
                        }                       
                        break;
                    case "Triple":
                        points *= 3;
                        if (points > currentPoints)
                        {
                            shotsUnsuccess++;
                            continue;
                        }
                        if(points<=currentPoints)
                        {
                            shotsSuccess++;                          
                            currentPoints -= points;
                        }                      
                        break;
                        
                }
               
                if (currentPoints==0)
                {
                    Console.WriteLine($"{name} won the leg with {shotsSuccess} shots.");
                    break;
                }
                

            }
        }
    }
}
