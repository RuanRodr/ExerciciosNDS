using System;
using Microsoft.VisualBasic;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("Por favor digite seu nome completo:");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Resoluções: \n ");
                
            Console.WriteLine(nome.Trim());
            
            Console.WriteLine(nome.Replace(" ", ""));
            
            Console.WriteLine(nome.ToLower());
            
            Console.WriteLine(nome.ToUpper());

            Console.WriteLine(string.Concat("Começou em >>> ", nome, ""));

            Console.WriteLine(nome.Replace("a", ""));
            
            Console.WriteLine(nome.Contains("a"));
            
            Console.WriteLine(nome.Replace(" ", " ").Length);
        }
    }
}