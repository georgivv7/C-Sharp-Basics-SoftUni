using System;

namespace PasswordGenerator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int asciiCode = 96;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (char k = 'a'; k <=asciiCode+l; k++)
                    {
                        for (char m = 'a'; m <= asciiCode+l; m++)
                        {
                            for (int y = 1; y <= n; y++)
                            {
                                if (y>i&&y>j)
                                {
                                    Console.Write($"{i}{j}{k}{m}{y} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
