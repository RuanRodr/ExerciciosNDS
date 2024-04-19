using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y;

            x = float.Parse(Console.ReadLine());
            y = float.Parse(Console.ReadLine());

            float media = (x + y) / 2;
            
            Console.WriteLine(media);
        }
    }
}