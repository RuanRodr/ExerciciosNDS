using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace WumpusGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string player = "@";
            string monstro = "&";
            string tesouro = "$";
            int pont = 1000;
            
            Console.WriteLine("Digite o tamanho do tabuleiro (minimo 5):");
            
            int qtd = int.Parse(Console.ReadLine());

            if (qtd < 5)
            {
                Console.WriteLine("Digite um valor acima de 5");
                System.Environment.Exit(0);
            }
            
            Random rand = new Random();
            
            int PlayerPosiX = rander(qtd);
            int PlayerPosiY = rander(qtd);
            int MonstroPosiX;
            int MonstroPosiY;
            int TesouroPosi;

            do
            {
                MonstroPosiX = rander(qtd);
                MonstroPosiY = rander(qtd);

                TesouroPosi = rander(qtd);

            } while (MonstroPosiX == PlayerPosiX || MonstroPosiY == PlayerPosiY || 
                     TesouroPosi == PlayerPosiX || MonstroPosiX == TesouroPosi);

            do
            {
                Console.Clear();
                
                for (int i = -2; i <= qtd; i++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();


                for (int i = 0; i < qtd; i++)
                {
                    Console.Write("#");

                    for (int j = 0; j <= qtd; j++)
                    {

                        if (i == PlayerPosiX && j == PlayerPosiY)
                        {
                            Console.Write(player);
                        }

                        else if (i == MonstroPosiX && j == MonstroPosiY)
                        {
                            Console.Write(monstro);
                        }
                        else if (i == TesouroPosi && j == TesouroPosi)
                        {
                            Console.Write(tesouro);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    Console.WriteLine("#");
                }
                
                
                for (int i = -2; i <= qtd; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                
                Menu();

                ConsoleKeyInfo key = Console.ReadKey();
                
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        
                        PlayerPosiX--;
                       
                        break;
                    
                    case ConsoleKey.DownArrow:
                        
                        PlayerPosiX++;
                        
                        break;
                    
                    case ConsoleKey.RightArrow:
                        
                        PlayerPosiY++;
                        
                        break;
                    
                    case ConsoleKey.LeftArrow:

                        PlayerPosiY--;
                        
                        break;
                    
                    default:
                        
                        Console.WriteLine("SE MOVAAAA");
                        Thread.Sleep(1000);
                        break;
                }
                

                int chance = rander(2);
                
                if (chance == 1)
                {
                    if (PlayerPosiY > MonstroPosiY && PlayerPosiX <= MonstroPosiX)
                        MonstroPosiY++;

                    else if (PlayerPosiX > MonstroPosiX && PlayerPosiY <= MonstroPosiY)
                        MonstroPosiX++;

                    else if (PlayerPosiY < MonstroPosiY && PlayerPosiX >= MonstroPosiX)
                        MonstroPosiY--;

                    else if (PlayerPosiX < MonstroPosiX && PlayerPosiY >= MonstroPosiY)
                        MonstroPosiX--;

                    else if (PlayerPosiY < MonstroPosiY && PlayerPosiX <= MonstroPosiX)
                        MonstroPosiX--;

                    else if (PlayerPosiX < MonstroPosiX && PlayerPosiY <= MonstroPosiY)
                        MonstroPosiY--;
                }
                
                pont += -1;

                if (PlayerPosiX < 0 || PlayerPosiX >= qtd || PlayerPosiY < 0 || PlayerPosiY >= qtd)
                {
                    Console.WriteLine("Você saiu do tabuleiro!");
                    Console.WriteLine($"Você conquistou {pont} pontos!!!");
                    break;
                }

                if (PlayerPosiX == TesouroPosi && PlayerPosiY == TesouroPosi)
                {
                    Console.WriteLine("Você venceu!!!");
                    Console.WriteLine($"Você conquistou {pont} pontos!!!");
                    break;
                }

                if (PlayerPosiY == MonstroPosiY && PlayerPosiX == MonstroPosiX)
                {
                    Console.WriteLine("O monstro te pegou!!! Você perdeu :(");
                    Console.WriteLine($"Você conquistou {pont} pontos!!!");
                    break;
                }
                
            } while (PlayerPosiX != TesouroPosi || PlayerPosiY != TesouroPosi);
        }

        static int rander(int qtd)
        {
            Random rand = new Random();
            
            qtd = rand.Next(0, qtd);
            return (qtd);   
        }

        static void Menu()
        {
            Console.WriteLine("\u21a5 Sobe");
            Console.WriteLine("\u21a7 Desce");
            Console.WriteLine("\u21a4 Esquerda");
            Console.WriteLine("\u21a6 Direita");
            Console.WriteLine("Faça seu movimento:");
        }
    }
}