using System.Globalization; 
namespace Exercicio2SalarioMedio;

class Program {
    static void Main(string[] args)
    {
        Funcionario funcionario1 = new Funcionario();
        Funcionario funcionario2 = new Funcionario();

        Console.WriteLine("Dados do primeiro funcionário: ");
        funcionario1.Nome = Console.ReadLine();
        funcionario1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.WriteLine("Dados do segundo funcionário: ");
        funcionario2.Nome = Console.ReadLine();
        funcionario2.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        
        double salarioMedio = (funcionario1.Salario + funcionario2.Salario) / 2.0;

        Console.WriteLine($"Salario médio {salarioMedio.ToString("F2",CultureInfo.InvariantCulture)}");
    }
}