using System.Globalization;

namespace Encapsulamento;

class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto("TV", 900.00, 10);

        produto.Nome = "TV-4k";
        Console.WriteLine($"Produto: {produto.Nome}");
        Console.WriteLine($"Preco: {produto.Preco.ToString("F2",CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Quantidade: {produto.Quantidade}");

        //Console.WriteLine($"{produto.GetNome()}");

        //produto.SetNome("TV-4K");
        //Console.WriteLine($"{produto.GetNome()}");
    }
}