using System;

namespace Exercicio03
{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite quantos números serão usados:");

        int x = int.Parse(Console.ReadLine());
        int maior = 0;
        int menor = int.MaxValue;
        
        for (int i = 0; i < x; i++)
        {
            Console.WriteLine("Digite um número:");
            int num = int.Parse(Console.ReadLine());

            if (num > maior)
                maior = num; //certo

            if (num < menor)
                menor = num; //certo
            
        }
        Console.WriteLine($"O maior número é {maior}");
        Console.WriteLine($"O menor número é {menor}");
    }    
}
}