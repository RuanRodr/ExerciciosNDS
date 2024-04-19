using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            
            Console.WriteLine("Digite 3 números:");

            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            z = double.Parse(Console.ReadLine());

            if (x > y && x > z)
                Console.WriteLine($"O número {x} é o maior");
            else if (y > x && y > z)
                Console.WriteLine($"O número {y} é o maior");
            else
                Console.WriteLine($"O número {z} é o maior");

            if (x < y && x < z)
                Console.WriteLine($"O número {x} é o menor");
            else if (y < x && y < z)
                Console.WriteLine($"O número {y} é menor");
            else
                Console.WriteLine($"O número {z} é menor");
        }
    }
}

