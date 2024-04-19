using System;
using System.Globalization;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite a quantidade de numeros que desaja imprimir:");
            int qtd = int.Parse(Console.ReadLine());

            int fibo = 1;
            int x = 0;
            int y = 0;

            if (qtd <= 0)
            {
                Console.WriteLine("Digite um valor positivo");
                System.Environment.Exit(0);
            }
            
            if(qtd == 1)
                Console.WriteLine(fibo);
            
            if (qtd > 1)
            {
                Console.WriteLine(fibo);
                for (int i = 0; i < qtd; i++)
                {
                    y = fibo + x;
                    Console.WriteLine(y);
                    x = fibo;
                    fibo = y;
                }
            }
        }
    }
}