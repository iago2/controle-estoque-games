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
                System.Console.WriteLine(" 3 - Deletar Jogo");
                System.Console.WriteLine(" 4 - Atualizar Jogo");
                System.Console.WriteLine(" 0 - Sair");
                System.Console.WriteLine("-----------------------------------------");

                // Validação Menu
                System.Console.Write("Digite a opção que deseja: ");
                bool decisao = int.TryParse(Console.ReadLine()!, out int decisaoValidada);

                if (!decisao)
                {
                    Console.WriteLine("Opção Inválida! Digite apenas Números");
                    Console.ReadKey();
                    return;
                }

                switch (decisaoValidada)
                {
                    case 1: CadastroJogo(joguinhos); break;
                    case 2: ListarJogos(joguinhos); break;
                    case 3: DeletarJogos(joguinhos); break;
                    case 4: AtualizarJogos(joguinhos); break;
                    case 0: Sair(); break;
                    default:
                        {
                            System.Console.WriteLine("Opção inexistente! Escolha um número de 0 a 4.");
                            Console.ReadKey();
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

            bool nome = false;
            string nomeValidado = "";

            //Validação Nome do Jogo

            while (!nome)
            {

                System.Console.Write("Digite qual o Nome do Jogo que deseja cadastrar: ");
                nomeValidado = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(nomeValidado))
                {

                    System.Console.WriteLine("Erro: informe o nome do jogo!");

                }
                else
                {
                    nome = true;
                }

            }



            // Validação Preço do Jogo
            bool preco = false;
            decimal precoValidado = 0;

            while (!preco)
            {
                System.Console.Write("Digite qual o Preço do Jogo que deseja cadastrar: ");
                preco = decimal.TryParse(Console.ReadLine()!, out precoValidado);

                if (preco == true && precoValidado < 0)
                {
                    Console.WriteLine("Erro: não são permitidos números negativos!");
                    Console.WriteLine("Pressione qualquer tecla para tentar novamente...\n");
                    Console.ReadKey();
                    preco = false;


                }
                else if (!preco)
                {
                    Console.WriteLine("Erro: informe um preço válido!");
                    Console.WriteLine("Pressione qualquer tecla para tentar novamente...\n");
                    Console.ReadKey();



                }

            }

            // Validação da Distribuidora


            bool distribuidora = false;
            string distribuidoraValidado = "";

            while (!distribuidora)
            {
                System.Console.Write("Digite qual a Distribuidora do Jogo que deseja cadastrar: ");
                distribuidoraValidado = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(distribuidoraValidado))
                {
                    System.Console.WriteLine("Erro: informe a distribuidora do jogo!");
                }
                else
                {
                    distribuidora = true;
                }


            }

            // Validação Ano de Lançamento
            bool anoLancamento = false;
            int anoLancamentoValidado = 0;

            while (!anoLancamento)
            {


                System.Console.Write("Digite qual o Ano de Lançamento do Jogo que deseja cadastrar: ");
                anoLancamento = int.TryParse(Console.ReadLine()!, out anoLancamentoValidado);

                if (anoLancamento == true && anoLancamentoValidado < 0)
                {
                    Console.WriteLine("Erro: não são permitidos números negativos!");
                    Console.WriteLine("Pressione qualquer tecla para tentar novamente...\n");
                    Console.ReadKey();
                    anoLancamento = false;
                }
                else if (!anoLancamento)
                {
                    Console.WriteLine("Erro: informe um ano de lançamento válido!");
                    Console.WriteLine("Pressione qualquer tecla para tentar novamente...\n");
                    Console.ReadKey();
                }
            }


            // Validação Gênero
            bool genero = false;
            string generoValidado = "";

            while (!genero)
            {
                System.Console.Write("Digite qual o Gênero do Jogo que deseja cadastrar: ");
                generoValidado = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(generoValidado))
                {
                    System.Console.WriteLine("Erro: informe o gênero do jogo!");
                }
                else
                {
                    genero = true;
                }
            }


            // Validação Console
            bool console = false;
            string consoleValidado = "";

            while (!console)
            {
                System.Console.Write("Digite qual o Console do Jogo que deseja cadastrar: ");
                consoleValidado = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(consoleValidado))
                {
                    System.Console.WriteLine("Erro: informe o console do jogo!");
                }
                else
                {
                    console = true;
                }
            }


            // Validação Quantidade de Estoque
            bool quantidadeEstoque = false;
            int quantidadeEstoqueValidado = 0;

            while (!quantidadeEstoque)
            {
                System.Console.Write("Digite qual o Estoque do Jogo que deseja cadastrar: ");
                quantidadeEstoque = int.TryParse(Console.ReadLine()!, out quantidadeEstoqueValidado);

                if (quantidadeEstoque == true && quantidadeEstoqueValidado < 0)
                {
                    Console.WriteLine("Erro: não são permitidos números negativos!");
                    Console.WriteLine("Pressione qualquer tecla para tentar novamente...\n");
                    Console.ReadKey();
                    quantidadeEstoque = false;
                }
                else if (!quantidadeEstoque)
                {
                    Console.WriteLine("Erro: informe uma quantidade em estoque válida!");
                    Console.WriteLine("Pressione qualquer tecla para tentar novamente...\n");
                    Console.ReadKey();
                }
            }

            Jogos novojogo = new(nomeValidado, precoValidado, distribuidoraValidado, generoValidado, anoLancamentoValidado, consoleValidado, quantidadeEstoqueValidado);
            joguinhos.Add(novojogo);

            Console.Clear();

            System.Console.WriteLine("Cadastrando Jogo no Sistema....");
            Thread.Sleep(2000);
            System.Console.WriteLine("Jogo Cadastrado com Sucesso!");
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
            string detalhesJogo = (Console.ReadLine()!.ToLower());


            if (detalhesJogo != "s" && detalhesJogo != "n")
            {
                System.Console.WriteLine("Val!");
                Console.ReadKey();
                return;
            }

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
                    Console.WriteLine("Erro, Digite um número válido na lista");
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



            Console.ReadKey();
        }

        public static void DeletarJogos(List<Jogos> joguinhos)
        {
            Console.Clear();
            System.Console.WriteLine("**** Deletando Jogo ****");
            System.Console.WriteLine("-----------------------------------------");


            for (int i = 0; i < joguinhos.Count; i++)
            {
                System.Console.WriteLine($"{i + 1}. {joguinhos[i].nome} (Estoque: {joguinhos[i].quantidadeEstoque})");
            }


            Console.Write("\nDigite o número do jogo: ");
            bool sucesso = int.TryParse(Console.ReadLine(), out int decisaoDeletar);

            if (!sucesso)
            {
                Console.WriteLine("Entrada inválida!");
                Console.ReadKey();
                return;
            }

            int indice = decisaoDeletar - 1;


            if (indice < 0 || indice >= joguinhos.Count)
            {
                Console.WriteLine("Erro: número inválido!");
                Console.ReadKey();
                return;
            }

            Jogos jogoSelecionado = joguinhos[indice];


            Console.WriteLine($"\nDeseja remover 1 unidade de: {jogoSelecionado.nome}? (S/N)");
            string resposta = Console.ReadLine()!.ToLower();

            if (resposta == "s")
            {

                if (jogoSelecionado.quantidadeEstoque > 0)
                {
                    jogoSelecionado.quantidadeEstoque--;

                    Console.WriteLine("\nBaixando estoque...");
                    Thread.Sleep(1000);

                    Console.WriteLine($"Estoque restante: {jogoSelecionado.quantidadeEstoque}");


                    if (jogoSelecionado.quantidadeEstoque == 0)
                    {
                        joguinhos.RemoveAt(indice);
                        Console.WriteLine("Jogo removido do sistema (estoque zerado).");
                    }
                }
                else
                {
                    Console.WriteLine("Este jogo já está sem estoque.");
                }
            }
            else
            {
                Console.WriteLine("Operação cancelada.");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar...");
            Console.ReadKey();
        }

        public static void AtualizarJogos(List<Jogos> joguinhos)
        {
            Console.Clear();
            System.Console.WriteLine("**** Atualizando Jogo ****");
            System.Console.WriteLine("-----------------------------------------");

            for (int i = 0; i < joguinhos.Count; i++)
            {
                System.Console.WriteLine($"{i + 1}. {joguinhos[i].nome}");

            }

            System.Console.Write("Digite o número do Jogo que deseja Atualizar:");
            int decisaoAtualizar = Convert.ToInt32(Console.ReadLine());

            int indice = decisaoAtualizar - 1;
            Jogos atualizarSelecionado = joguinhos[indice];

            Console.Clear();
            atualizarSelecionado.Apresentar();


            System.Console.WriteLine("\nDeseja Atualizar qual elemento do Jogo? Digite o Número ");
            System.Console.Write("Digite:");
            int atualizarEscolhido = Convert.ToInt32(Console.ReadLine()!.ToLower());

            switch (atualizarEscolhido)
            {
                case 1:
                    {
                        Console.Clear();
                        System.Console.WriteLine("**** Atualizando Nome ****");
                        System.Console.WriteLine("-----------------------------------------");
                        Console.Clear();
                        System.Console.WriteLine($"Nome atual: {joguinhos[indice].nome}");
                        System.Console.Write("Novo Nome:");
                        string novoNome = Console.ReadLine()!;
                        System.Console.WriteLine($"Confirma Atualizar o Preço para {novoNome}? S ou N");
                        System.Console.Write("R= ");
                        string confirma = Console.ReadLine()!.ToLower();
                        if (confirma == "s")
                        {
                            Console.Clear();
                            System.Console.WriteLine("Atualizando Nome.....");
                            Thread.Sleep(2000);
                            joguinhos[indice].nome = novoNome;
                            System.Console.WriteLine("Nome Atualizado com Sucesso!!");
                        }
                        else if (confirma == "n")
                        {
                            Console.Clear();
                            System.Console.WriteLine("Atualização Cancelada. Voltando ao Menu.....");
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            System.Console.WriteLine("Digite uma opção Válida!");
                            System.Console.WriteLine("Confirma essa Atualização? S ou N");
                            System.Console.Write("R= ");
                            confirma = Console.ReadLine()!.ToLower();
                        }
                        break;


                    }
                case 2:
                    {
                        Console.Clear();
                        System.Console.WriteLine("**** Atualizando Preço ****");
                        System.Console.WriteLine("-----------------------------------------");
                        Console.Clear();
                        System.Console.WriteLine($"Preço atual: {joguinhos[indice].preco}");
                        System.Console.Write("Novo Preço:");
                        int novoPreco = Convert.ToInt32(Console.ReadLine()!);
                        System.Console.WriteLine($"Confirma Atualizar o Preço para R${novoPreco:f2}? S ou N");
                        System.Console.Write("R=");
                        string confirma = Console.ReadLine()!.ToLower();
                        if (confirma == "s")
                        {
                            Console.Clear();
                            System.Console.WriteLine("Atualizando Preço.....");
                            Thread.Sleep(2000);
                            joguinhos[indice].preco = novoPreco;
                            System.Console.WriteLine("Preço Atualizado com Sucesso!!");

                        }
                        else if (confirma == "n")
                        {
                            Console.Clear();
                            System.Console.WriteLine("Atualização Cancelada. Voltando ao Menu.....");
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            System.Console.WriteLine("Digite uma opção Válida!");
                            System.Console.WriteLine("Confirma essa Atualização? S ou N");
                            System.Console.Write("R= ");
                            confirma = Console.ReadLine()!.ToLower();
                        }
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        System.Console.WriteLine("**** Atualizando Distribuidora ****");
                        System.Console.WriteLine("-----------------------------------------");
                        Console.Clear();
                        System.Console.WriteLine($"Distribuidora atual: {joguinhos[indice].distribuidora}");
                        System.Console.Write("Nova Distribuidora:");
                        string novaDistribuidora = Console.ReadLine()!;
                        System.Console.WriteLine($"Confirma Atualizar a Distribuidora para {novaDistribuidora}? S ou N");
                        System.Console.Write("R= ");
                        string confirma = Console.ReadLine()!.ToLower();
                        if (confirma == "s")
                        {
                            Console.Clear();
                            System.Console.WriteLine("Atualizando Distribuidora.....");
                            Thread.Sleep(2000);
                            joguinhos[indice].distribuidora = novaDistribuidora;
                            System.Console.WriteLine("Distribuidora Atualizada com Sucesso!!");

                        }
                        else if (confirma == "n")
                        {
                            Console.Clear();
                            System.Console.WriteLine("Atualização Cancelada. Voltando ao Menu.....");
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            System.Console.WriteLine("Digite uma opção Válida!");
                            System.Console.WriteLine("Confirma essa Atualização? S ou N");
                            System.Console.Write("R= ");
                            confirma = Console.ReadLine()!.ToLower();
                        }
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        System.Console.WriteLine("**** Atualizando Ano Lançamento ****");
                        System.Console.WriteLine("-----------------------------------------");
                        Console.Clear();
                        System.Console.WriteLine($"Ano Lançamento: {joguinhos[indice].anoLancamento}");
                        System.Console.Write("Novo Ano Lançamento:");
                        int novoAnolancamento = Convert.ToInt32(Console.ReadLine()!);
                        System.Console.WriteLine($"\nConfirma Atualizar o Ano de Lançamento para {novoAnolancamento}? S ou N");
                        System.Console.Write("R= ");
                        string confirma = Console.ReadLine()!.ToLower();
                        if (confirma == "s")
                        {
                            Console.Clear();
                            System.Console.WriteLine("Atualizando Preço.....");
                            Thread.Sleep(2000);
                            joguinhos[indice].anoLancamento = novoAnolancamento;
                            System.Console.WriteLine("Ano Lançamento Atualizado com Sucesso!!");

                        }
                        else if (confirma == "n")
                        {
                            Console.Clear();
                            System.Console.WriteLine("Atualização Cancelada. Voltando ao Menu.....");
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            System.Console.WriteLine("Digite uma opção Válida!");
                            System.Console.WriteLine("Confirma essa Atualização? S ou N");
                            System.Console.Write("R= ");
                            confirma = Console.ReadLine()!.ToLower();
                        }
                        break;
                    }
                case 5:
                    {
                        Console.Clear();
                        System.Console.WriteLine("**** Atualizando Gênero ****");
                        System.Console.WriteLine("-----------------------------------------");
                        Console.Clear();
                        System.Console.WriteLine($"Gênero atual: {joguinhos[indice].genero}");
                        System.Console.Write("Novo Gênero:");
                        string novoGenero = Console.ReadLine()!;
                        System.Console.WriteLine($"\nConfirma Atualizar o Gênero para {novoGenero}? S ou N");
                        System.Console.Write("R= ");
                        string confirma = Console.ReadLine()!.ToLower();
                        if (confirma == "s")
                        {
                            Console.Clear();
                            System.Console.WriteLine("Atualizando Preço.....");
                            Thread.Sleep(2000);
                            joguinhos[indice].genero = novoGenero;
                            System.Console.WriteLine("Genêro Atualizado com Sucesso!!");

                        }
                        else if (confirma == "n")
                        {
                            Console.Clear();
                            System.Console.WriteLine("Atualização Cancelada. Voltando ao Menu.....");
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            System.Console.WriteLine("Digite uma opção Válida!");
                            System.Console.WriteLine("Confirma essa Atualização? S ou N");
                            System.Console.Write("R= ");
                            confirma = Console.ReadLine()!.ToLower();
                        }
                        break;
                    }
                case 6:
                    {
                        Console.Clear();
                        System.Console.WriteLine("**** Atualizando Console ****");
                        System.Console.WriteLine("-----------------------------------------");
                        Console.Clear();
                        System.Console.WriteLine($"Console atual: {joguinhos[indice].console}");
                        System.Console.Write("Novo Console:");
                        string novoConsole = Console.ReadLine()!;
                        System.Console.WriteLine($"\nConfirma Atualizar o Console para {novoConsole}? S ou N");
                        System.Console.Write("R= ");
                        string confirma = Console.ReadLine()!.ToLower();
                        if (confirma == "s")
                        {
                            Console.Clear();
                            System.Console.WriteLine("Atualizando Console.....");
                            Thread.Sleep(2000);
                            joguinhos[indice].console = novoConsole;
                            System.Console.WriteLine("Console Atualizado com Sucesso!!");

                        }
                        else if (confirma == "n")
                        {
                            Console.Clear();
                            System.Console.WriteLine("Atualização Cancelada. Voltando ao Menu.....");
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            System.Console.WriteLine("Digite uma opção Válida!");
                            System.Console.WriteLine("Confirma essa Atualização? S ou N");
                            System.Console.Write("R= ");
                            confirma = Console.ReadLine()!.ToLower();
                        }
                        break;
                    }
                case 7:
                    {
                        Console.Clear();
                        System.Console.WriteLine("**** Atualizando Estoque ****");
                        System.Console.WriteLine("-----------------------------------------");
                        Console.Clear();
                        System.Console.WriteLine($"Estoque atual: {joguinhos[indice].quantidadeEstoque}");
                        System.Console.Write("Novo Estoque:");
                        int novoEstoque = Convert.ToInt32(Console.ReadLine()!);
                        System.Console.WriteLine($"\nConfirma Atualizar o Estoque para {novoEstoque}? S ou N");
                        System.Console.Write("R= ");
                        string confirma = Console.ReadLine()!.ToLower();
                        if (confirma == "s")
                        {
                            Console.Clear();
                            System.Console.WriteLine("Atualizando Estoque.....");
                            Thread.Sleep(2000);
                            joguinhos[indice].quantidadeEstoque = novoEstoque;
                            System.Console.WriteLine("Estoque Atualizado com Sucesso!!");

                        }
                        else if (confirma == "n")
                        {
                            Console.Clear();
                            System.Console.WriteLine("Atualização Cancelada. Voltando ao Menu.....");
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            System.Console.WriteLine("Digite uma opção Válida!");
                            System.Console.WriteLine("Confirma essa Atualização? S ou N");
                            System.Console.Write("R= ");
                            confirma = Console.ReadLine()!.ToLower();
                        }
                        break;
                    }

            }




            Console.ReadKey();
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