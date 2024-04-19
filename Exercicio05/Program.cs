using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de números para se fazer a média aritmética");
            int qtd = int.Parse(Console.ReadLine());
            float num = 0f;

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Digite um número para a média");
                float numbers = float.Parse(Console.ReadLine());
                num += numbers;
                Console.WriteLine($"Soma: {num}");
            }

            float media = num / qtd;
            
            Console.WriteLine($"A média é: {media}");

        }
    }
}