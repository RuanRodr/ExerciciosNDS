using System;

namespace Exercicio11
{
    class Program
    {
        struct Id
        {
            public string Name;
            public string LastName;
            public int Idade;
            public double Altura;
        }
        
        static void Main(string[] args)
        {
            Console.Clear();
            
            Id Pessoa = new Id();

            Pessoa.Name = (Console.ReadLine());
            Pessoa.LastName = (Console.ReadLine());
            Pessoa.Idade = int.Parse(Console.ReadLine());
            Pessoa.Altura = double.Parse(Console.ReadLine());
            
            Console.WriteLine(Pessoa.Name);
            Console.WriteLine(Pessoa.LastName);
            Console.WriteLine(Pessoa.Idade);
            Console.WriteLine(Pessoa.Altura);
        }
    }
}