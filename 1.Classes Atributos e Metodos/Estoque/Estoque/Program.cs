using System.Globalization;

namespace Estoque;

class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto();

        Console.WriteLine("Entre com os dados do produto: ");
        Console.Write("Nome: ");
        produto.Nome = Console.ReadLine();
        Console.Write("Preco: ");
        produto.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.Write("Quantidade no estoque: ");
        produto.Quantidade = int.Parse(Console.ReadLine());
        
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