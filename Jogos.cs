using System.Formats.Asn1;

public class Jogos
{
    public string nome;
    public decimal preco;
    public string distribuidora;
    public string genero;
    public int anoLancamento;
    public string console;
    public int quantidadeEstoque;

    public Jogos(string nome, decimal preco, string distribuidora, string genero, int anoLancamento, string console, int quantidadeEstoque)
    {
        this.nome = nome;
        this.preco = preco;
        this.distribuidora = distribuidora;
        this.genero = genero;
        this.anoLancamento = anoLancamento;
        this.console = console;
        this.quantidadeEstoque = quantidadeEstoque;
    }

    public void Apresentar()
    {
        Console.WriteLine($"Nome do Jogo: {nome}"!);
        System.Console.WriteLine($"Preço do Jogo: R$ {preco:f2}");
        System.Console.WriteLine($"Distribuidora: {distribuidora}");
        System.Console.WriteLine($"Gênero: {genero}");
        System.Console.WriteLine($"Ano de Lançamento: {anoLancamento}");
        System.Console.WriteLine($"Console: {console}");
        System.Console.WriteLine($"Quantidade em Estoque: {quantidadeEstoque}");
    }


}


