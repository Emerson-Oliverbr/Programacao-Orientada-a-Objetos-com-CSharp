using System.Globalization;

namespace MembrosEstaticosParte3;

class Program
{
    static void Main(string[] args)
    {
        Funcionario funcionarioX = new Funcionario("Emerson", 100.0, 15.0);
        Funcionario funcionarioY = new Funcionario("Daniela", 80.0, 10.0);

        double resultado = CalculaSalario.ValorPago(100.0, 15.0);
        double total = funcionarioX.ValorPago();

        Console.WriteLine($"R$ {funcionarioX.ValorPago().ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"R$ {funcionarioY.ValorPago().ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine();
        Console.WriteLine($"R$ {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}