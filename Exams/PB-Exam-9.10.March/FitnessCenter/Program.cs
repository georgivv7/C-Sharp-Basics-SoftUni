using System;

namespace FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            double back = 0;
            double chest = 0;
            double legs = 0;
            double abs = 0;
            double proteinBar = 0;
            double proteinShake = 0;
            double workout = 0;
            double products = 0;
            for (int i = 1; i <= numOfPeople; i++)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case"Back":
                        workout++;
                        back++;
                        break;
                    case "Chest":
                        workout++;
                        chest++;
                        break;
                    case "Legs":
                        workout++;
                        legs++;
                        break;
                    case "Abs":
                        workout++;
                        abs++;
                        break;
                    case "Protein shake":
                        products++;
                        proteinShake++;
                        break;
                    case "Protein bar":
                        products++;
                        proteinBar++;
                        break;
                }
            }
            double percentWorkout = workout / numOfPeople * 100;
            double percentProduct = products / numOfPeople * 100;
            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{proteinShake} - protein shake");
            Console.WriteLine($"{proteinBar} - protein bar");
            Console.WriteLine($"{percentWorkout:f2}% - work out");
            Console.WriteLine($"{percentProduct:f2}% - protein");

        }
    }
}
