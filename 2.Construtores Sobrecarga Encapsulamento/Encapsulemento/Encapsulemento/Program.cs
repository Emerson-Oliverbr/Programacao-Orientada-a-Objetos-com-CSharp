using System.Globalization;

namespace Encapsulamento;

class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto("TV", 900.00, 10);
        Console.WriteLine($"{produto.GetNome()}");
        
        produto.SetNome("TS-4K");
        Console.WriteLine($"{produto.GetNome()}");
        

        
    }
}