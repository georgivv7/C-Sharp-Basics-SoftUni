using System;

namespace _04.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            string input =Console.ReadLine();
            double income = 0;
            while (input!="Movie time!")
            {
                int numOfPeople = int.Parse(input);
                if (numOfPeople > capacity)
                {
                    Console.WriteLine("The cinema is full.");
                    break;
                }
                income += 5 * numOfPeople;
                if (numOfPeople%3==0)
                {                   
                    income -= 5;
                }                               
                capacity -= numOfPeople;
                input =Console.ReadLine();
                
            }
            if (input=="Movie time!")
            {
                Console.WriteLine($"There are {capacity} seats left in the cinema.");
            }            
            Console.WriteLine($"Cinema income - {income} lv.");
        }
    }
}
