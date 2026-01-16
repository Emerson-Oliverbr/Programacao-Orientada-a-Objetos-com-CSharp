using System.Globalization;

namespace Estoque;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com os dados do produto: ");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Preco: ");
        double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.Write("Quantidade no estoque: ");
        int quantidade = int.Parse(Console.ReadLine());
        
        Produto produto = new Produto(nome, preco, quantidade);
        
        Console.WriteLine($"Dados do produto: {produto}");

        Console.Write("Digite a quantidade de produtos a serem adicionados ao estoque: ");
        int quant = int.Parse(Console.ReadLine());
        produto.AdicionarProdutos(quant);
        Console.WriteLine($"Dados Atualizados: {produto}");
        
        Console.Write("Digite a quantidade de produtos a serem removidosdos do estoque: ");
        quant = int.Parse(Console.ReadLine());
        produto.RemoverProdutos(quant);
        Console.WriteLine($"Dados Atualizados: {produto}");
    }
}