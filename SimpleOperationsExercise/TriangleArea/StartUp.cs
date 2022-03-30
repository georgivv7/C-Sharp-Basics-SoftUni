using System;

namespace TriangleArea
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double strana = double.Parse(Console.ReadLine());
            double visochina = double.Parse(Console.ReadLine());

            double area = strana * visochina / 2;
            Console.WriteLine($"{area:f2}");
        }
    }
}
