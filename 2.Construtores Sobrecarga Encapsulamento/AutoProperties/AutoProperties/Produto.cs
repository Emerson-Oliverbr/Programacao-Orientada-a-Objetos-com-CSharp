using System.Globalization;
namespace Encapsulamento;

public class Produto
{
    private string _nome;
    public double Preco { get; private set; }
    public int Quantidade {get; private set; }

    public Produto()
    {
    }

    public Produto(string nome, double preco, int quantidade)
    {
        _nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public string Nome
    {
        get {return _nome;}
        set
        {
            if (value != null && value.Length >= 2)
            {
                _nome = value;
            }
        }
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
        return $"{_nome}, Preco R${Preco.ToString("F2",CultureInfo.InvariantCulture)}, unidades {Quantidade}, total R$ {ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture)}";
    }
}