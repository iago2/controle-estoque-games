using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace ControleEstoqueGames
{
    public class Program
    {

        static List<Jogos> joguinhos = new List<Jogos>();


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
                    case 1: CadastroJogo(joguinhos); break;
                    case 2: ListarJogos(joguinhos); break;
                    case 3: Sair(); break;
                    default:
                        {
                            System.Console.WriteLine("Opção Invalida");
                            break;
                        }
                }

            }
        }

        public static void CadastroJogo(List<Jogos> joguinhos)
        {
            Console.Clear();
            System.Console.WriteLine("***** Cadastro de Jogos *****");
            System.Console.WriteLine("-----------------------------------------");

            // Informações sobre o Jogo
            System.Console.Write("Digite qual o Nome do Jogo que deseja cadastrar: ");
            string nome = Console.ReadLine()!;
            System.Console.Write("Digite qual o Preço do Jogo que deseja cadastrar: ");
            decimal preco = decimal.Parse(Console.ReadLine()!);
            System.Console.Write("Digite qual a Distribuidora do Jogo que deseja cadastrar: ");
            string distribuidora = Console.ReadLine()!;
            System.Console.Write("Digite qual o Ano de Lançamento do Jogo que deseja cadastrar: ");
            int anoLancamento = int.Parse(Console.ReadLine()!);
            System.Console.Write("Digite qual o Gênero do Jogo que deseja cadastrar: ");
            string genero = Console.ReadLine()!;
            System.Console.Write("Digite qual o Console do Jogo que deseja cadastrar: ");
            string console = Console.ReadLine()!;
            System.Console.Write("Digite qual a Quantidade em Estoque do Jogo que deseja cadastrar: ");
            int quantidadeEstoque = int.Parse(Console.ReadLine()!);

            Jogos novojogo = new(nome, preco, distribuidora, genero, anoLancamento, console, quantidadeEstoque);
            joguinhos.Add(novojogo);

            Console.Clear();

            System.Console.WriteLine("Cadastrando Jogo em Nosso Sistema....");
            Thread.Sleep(2000);
            System.Console.WriteLine("Jogo Cadastrado com Sucesso!!");
            Thread.Sleep(1000);


        }

        public static void ListarJogos(List<Jogos> joguinhos)
        {
            Console.Clear();
            System.Console.WriteLine("***** Listagem de Jogos *****");
            System.Console.WriteLine("-----------------------------------------");

            for (int i = 0; i < joguinhos.Count; i++)
            {
                System.Console.WriteLine($"{i + 1}.{joguinhos[i].nome}");
            }

            System.Console.WriteLine("Deseja ver mais detalhes de um Jogo? ( S = Sim ou N = Não)");
            System.Console.Write("Responda = ");
            string detalhesJogo = Console.ReadLine()!.ToLower();


            if (detalhesJogo == "s")
            {
                Console.Write("Digite o Número do Jogo que deseja ver: ");
                int decisaoDetalhes = int.Parse(Console.ReadLine()!);

                int indice = decisaoDetalhes - 1;

                if (indice >= 0 && indice < joguinhos.Count)
                {
                    Console.Clear();
                    Console.WriteLine("Buscando Detalhes do Jogo......");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine($"Detalhes do Jogo Abaixo");
                    System.Console.WriteLine("-----------------------------------------");
                    joguinhos[indice].Apresentar();

                    System.Console.WriteLine("\nDigite qualquer tecla para retornar ao Menu");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Erro, Digite um núemro válido na lista");
                    Console.ReadKey();
                }




            }


            else if (detalhesJogo == "n")
            {
                Console.WriteLine("Já que não deseja ver detalhes vamos retornar ao Menu!!");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Retornando ao Menu.......");
                Thread.Sleep(1000);

            }




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