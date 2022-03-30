using System;

namespace ExamPreparation
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numOfPoorMarks = int.Parse(Console.ReadLine());         
            int poorMarks = 0;
            double markSum = 0;
            int problemCounter = 0;
            string lastProblem = "";
            while (true)
            {
                string nameOfQuest =(Console.ReadLine());
                if (nameOfQuest == "Enough")
                {
                    break;                                     
                }
                int mark = int.Parse(Console.ReadLine());                                        
                if (mark<=4)
                {
                    poorMarks += 1;
                    if (poorMarks == numOfPoorMarks)
                    {
                        Console.WriteLine($"You need a break, {poorMarks} poor grades.");
                        break;
                    }
                }
                problemCounter++;
                markSum += mark;
                lastProblem = nameOfQuest;
            }
            if (poorMarks < numOfPoorMarks)
            {
                Console.WriteLine($"Average score: {markSum/problemCounter:f2}");
                Console.WriteLine($"Number of problems: {problemCounter}");
                Console.WriteLine($"Last problem: {lastProblem}");                            
            }
            

        }
    }
}
