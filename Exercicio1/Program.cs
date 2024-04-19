using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            
            Console.WriteLine("Digite um valor para X:");
            x = int.Parse(Console.ReadLine());
            
            if(x % 2 == 0){
                Console.WriteLine("O número é par");
            }
            else{
                Console.WriteLine("O número é impar");
                
            }
        }
    }
}