using System.Globalization;

namespace ExercicioFuncionario;

class Program
{
    static void Main(string[] args)
    {
        Funcionario funcionario = new Funcionario();

        Console.Write("Nome: ");
        funcionario.Nome = Console.ReadLine();
        Console.Write("Salário bruto: ");
        funcionario.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.Write("Imposto: ");
        funcionario.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        
        Console.WriteLine($"Funcionario: {funcionario}");
        
        Console.Write("Digite a porcentagem para aumentar o salário: ");
        double aumento = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        funcionario.AumentarSalario(aumento);
        Console.WriteLine($"Dados atualizados: {funcionario}");
    }
}