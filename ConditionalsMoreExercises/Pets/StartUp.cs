using System;

namespace Pets
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //            •	Първи ред – брой дни – цяло число в интервал[1…5000]
            //•	Втори ред – оставена храна в килограми – цяло число в интервал[0…100000]
            //•	Трети ред – храна на ден за кучето в килограми – реално число в интервал[0.00…100.00]
            //•	Четвърти ред – храна на ден за котката в килограми– реално число в интервал[0.00…100.00]
            //•	Пети ред – храна на ден за костенурката в грамове – реално число в интервал[0.00…10000.00]

            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double foodForDog = double.Parse(Console.ReadLine());
            double foodForCat = double.Parse(Console.ReadLine());
            double foodForTurtle = double.Parse(Console.ReadLine());

            double dogFood = foodForDog * days;
            double catFood = foodForCat * days;
            double turtleFood = (foodForTurtle * days)/1000;
            double allFood = dogFood + catFood + turtleFood;

            double difference = Math.Abs(foodLeft - allFood);
            
            if (foodLeft>=allFood)
            {
                Console.WriteLine($"{Math.Floor(difference)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(difference)} more kilos of food are needed.");
            }



        }
    }
}
