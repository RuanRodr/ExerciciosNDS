using System;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (;;)
            {
                 int qtd = 0;
                 float num = 0f;
                 float valor = 0f;
                 float num1 = 0f;
                 float num2 = 0f;
                
                Console.WriteLine("Escolha uma operação:\n1-Soma\n2-Subtração\n3-Multiplicação\n4-Divisão\n0-Exit");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:   //soma
                        
                        Console.WriteLine("Digite quantos números você deseja somar:");
                        qtd = int.Parse(Console.ReadLine());

                        for (int j = 0; j < qtd; j++)
                        {
                            Console.WriteLine("digite um número");
                            num = float.Parse(Console.ReadLine());
                            valor += num;
                        }
                        
                        Console.WriteLine($"A soma é : {valor}");
                        
                        break;

                    case 2:    //subtração

                        Console.WriteLine("Digite o primeiro número e em seguida digite o seu subtrator:");

                        num1 = float.Parse(Console.ReadLine());
                        num2 = float.Parse(Console.ReadLine());

                        valor = num1 - num2;
                        
                        Console.WriteLine($"A subtração deu : {valor}");
                        
                        break;

                    case 3:    //multiplicação

                        Console.WriteLine("Digite o primeiro número e em seguida digite o seu multiplicador:");

                        num1 = float.Parse(Console.ReadLine());
                        num2 = float.Parse(Console.ReadLine());

                        valor = num1 * num2;
                        
                        Console.WriteLine($"A multiplicação deu : {valor}");
                        
                        break;
                    
                    
                    case 4:    //divisão
                        
                        Console.WriteLine("Digite o primeiro número e em seguida digite o seu divisor:");
                        
                        num1 = float.Parse(Console.ReadLine());
                        num2 = float.Parse(Console.ReadLine());

                        valor = num1 / num2;

                        Console.WriteLine($"A divisão deu: {valor}");
                        break;

                    default:
                        Console.WriteLine("Fim do programa");
                        return;
                        break;
                }
            }
        }
    }
}