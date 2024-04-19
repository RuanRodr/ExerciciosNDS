using System;
using System.Runtime.InteropServices.JavaScript;

namespace ProjetoRPG
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            
            //Herói:
            short escolha = 0;
            String nome = "";
            double vida = 0;
            double ataque = 0;
            double esquiva = 0;
            
            //Vilão:
            String nomeVi = " ";
            double vidaVi = 0;
            double ataqueVi = 0;
            
            //menu
            Console.WriteLine("Por favor, escolha sua classe:");
            Console.WriteLine("1-Guerreiro");
            Console.WriteLine("2-Mago");
            Console.WriteLine("3-Arqueiro");
            Console.WriteLine("4-Assassino");
            Console.WriteLine("0-Sair");
             
            escolha = short.Parse(Console.ReadLine());
            
            switch (escolha)
            {
                case 1:
                    nome = "Guerreiro";
                    vida = 150;
                    ataque = 30;
                    esquiva = 6;
                    break;
                
                case 2:
                    nome = "Mago";
                    vida = 100;
                    ataque = 60;
                    esquiva = 12;
                    break;
                
                case 3:
                    nome = "Arqueiro";
                    vida = 120;
                    ataque = 40;
                    esquiva = 8;
                    break;
                
                case 4:
                    nome = "Assassino";
                    vida = 70;
                    ataque = 80;
                    esquiva = 16;
                    break;
                
                case 0:
                    System.Environment.Exit(0);
                    break;
                
                default:
                    Console.WriteLine("Por favor selecione uma classe novamente...");
                    Thread.Sleep(2000);
                    System.Environment.Exit(0);
                    break;
            }

            Console.WriteLine($"Você escolheu a classe: {nome}");
            Console.WriteLine($"Sua vida: {vida}");
            Console.WriteLine($"Seu ataque: {ataque}");
            Console.WriteLine($"Seu poder de esquiva: {esquiva}\n\n\n");

            
            Random rand = new Random();
            int vilao = rand.Next(1, 5);

            switch (vilao)
            {
                case 1:
                    nomeVi = "Slime";
                    vidaVi = 150;
                    ataqueVi = 20;
                    break;
                case 2:
                    nomeVi = "Ladrão";
                    vidaVi = 100;
                    ataqueVi = 25;
                    break;
                case 3:
                    nomeVi = "Rei Globin";
                    vidaVi = 200;
                    ataqueVi = 30;
                    break;
                case 4:
                    nomeVi = "Aranha Gigante";
                    vidaVi = 200;
                    ataqueVi = 20;
                    break;
            }
            Console.WriteLine($"Um vilão apareceu: {nomeVi}");
            Console.WriteLine($"Vida do vilão: {vidaVi}");
            Console.WriteLine($"Seu ataque: {ataqueVi}\n\n");

        
            do
            {
                Console.WriteLine("Deseja atacar ou esquivar?");
                
                Console.WriteLine("1-Atacar");
                Console.WriteLine("2-esquivar");

                escolha = short.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                if (escolha == 1)
                {
                    vidaVi -= ataque;
                    vida -= ataqueVi;
                    Console.WriteLine($"Você causou um dano!!! menos {ataque} de vida ao vilão");
                    Console.WriteLine($"O vilão te atacou!!! menos {ataqueVi} de vida a você");
                }
                else if (escolha == 2)
                {
                    int esq = rand.Next(1, 3);
                    
                    if (esq == 1)
                    {
                        vida -= ataqueVi / 2;
                        vidaVi -= esquiva;
                        
                        Console.WriteLine($"Você esquivou e causou {esquiva} de dano ao vilão!!\n");
                        Console.WriteLine($"mas o vilão te causou {ataqueVi / 2} de dano");
                    }
                    else
                    {
                        vida -= ataqueVi;
                        Console.WriteLine("Você não conseguiu esquivar.\n");
                        Console.WriteLine($"O vilão te atacou!!! menos {ataqueVi} de vida a você");
                    }
                }
                else
                {
                    vida -= ataqueVi;
                    Console.WriteLine("ATAQUE O VILÃO!!!!\n");
                }
                Console.WriteLine($"Sua vida: {vida}hp");
                Console.WriteLine($"A vida do vilão: {vidaVi}hp\n\n");

                
                if(vida <= 0 && vidaVi >= 0)
                    Console.WriteLine("Você morreu :(");
                else if(vidaVi <= 0 && vida >= 0)
                    Console.WriteLine("Você derrotou o vilão!!!");
                else if(vidaVi <= 0 && vida <= 0)
                    Console.WriteLine("Vocês dois morreram HAHAHAHA");
                
                
            } while (vida > 0 && vidaVi > 0);
        }
    }
}

