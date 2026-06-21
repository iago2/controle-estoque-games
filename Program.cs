using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace ControleEstoqueGames
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
            }

            static void Menu()
            {
                Console.Clear();
                System.Console.WriteLine("\n***** Controle de Estoque de Games *****");
                System.Console.WriteLine("-----------------------------------------");
                System.Console.WriteLine(" 1 - Cadastrar Jogo ");
                System.Console.WriteLine(" 2 - Listar Jogos");
                System.Console.WriteLine(" 3 - Sair");
                System.Console.WriteLine("-----------------------------------------");

                System.Console.Write("Digite a opção que deseja: ");
                int decisao = int.Parse(Console.ReadLine()!);

                switch (decisao)
                {
                    case 1: CadastroJogo(); break;
                    case 2: ListarJogos(); break;
                    case 3: Sair(); break;
                    default:
                        {
                            System.Console.WriteLine("Opção Invalida");
                            break;
                        }
                }
            }
        }

        public static void ListarJogos()
        {
            Console.Clear();
            System.Console.WriteLine("***** Listagem de Jogos *****");
            System.Console.WriteLine("-----------------------------------------");
        }

        public static void CadastroJogo()
        {
            Console.Clear();
            System.Console.WriteLine("***** Cadastro de Jogos *****");
            System.Console.WriteLine("-----------------------------------------");
        }

        public static void Sair()
        {
            Console.Clear();
            System.Console.WriteLine("Saindo do Sistema de Estoque........");
            Thread.Sleep(1000);
            System.Environment.Exit(0);
        }
    }
}