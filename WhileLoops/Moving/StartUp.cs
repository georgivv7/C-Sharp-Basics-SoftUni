using System;

namespace Moving
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int freeSpace = width * lenght * height;         

            while (input!="Done")
            {               
                var boxes = int.Parse(input);               
                boxes = int.Parse(input);
                freeSpace = freeSpace - boxes;

                boxes = int.Parse(input);
            }
            if (freeSpace>0)
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
            else if(freeSpace<0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
            }
           
        }
    }
}
