using System.Globalization;
namespace Estoque;
public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public Produto()
    {
    }

    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }
    public double ValorTotalEmEstoque()
    {
        return Quantidade * Preco;
    }

    public void AdicionarProdutos(int quantidade)
    {
        Quantidade += quantidade;
    }
    
    public void RemoverProdutos(int quantidade)
    {
        Quantidade -= quantidade;
    }
    
    public override string ToString()
    {
        return $"{Nome}, Preco R${Preco.ToString("F2",CultureInfo.InvariantCulture)}, unidades {Quantidade}, total R$ {ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture)}";
    }
}