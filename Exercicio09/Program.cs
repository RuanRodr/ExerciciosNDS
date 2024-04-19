using System;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamnaho do tabuleiro");
            
            Console.WriteLine("Altura:");
            int altura = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Largura:");
            int largura = int.Parse(Console.ReadLine());

            for (int i = -1; i <= largura; i++)
            {
                Console.Write("#");
            }
            
            Console.WriteLine();

            int valor = -1;
            
            for (int i = 0; i < altura; i++)
            {
                Console.Write("#");
                
                espaco(valor, altura);
                
                Console.WriteLine("#");
            }
            
            
            for (int i = -1; i <= largura; i++)
            {
                Console.Write("#");
            }
        }
        
        static void espaco(int valor, int altura)
            {
                while (valor != altura)
                {
                    Console.Write(" ");
                    valor++;
                            
                }
            }
    }
    
}

