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
        Console.WriteLine($"1.Nome do Jogo: {nome}"!);
        System.Console.WriteLine($"2.Preço do Jogo: R$ {preco:f2}");
        System.Console.WriteLine($"3.Distribuidora: {distribuidora}");
        System.Console.WriteLine($"4.Gênero: {genero}");
        System.Console.WriteLine($"5.Ano de Lançamento: {anoLancamento}");
        System.Console.WriteLine($"6.Console: {console}");
        System.Console.WriteLine($"7.Quantidade em Estoque: {quantidadeEstoque}");
    }


}


