using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número:");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o peso da nota:");
            int peso1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite outro número:");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o peso da segunda nota:");
            int peso2 = int.Parse(Console.ReadLine());

            float nota = ((x * peso1) + (y * peso2)) / 2;
                
            Console.WriteLine($"A nota ponderada é : {nota}");
        }
    }
}