using System.Globalization;
namespace ExercicioFuncionario;

public class Funcionario
{
    public string Nome;
    public double SalarioBruto;
    public double Imposto;

    public double SalarioLiquido()
    {
        return SalarioBruto - Imposto;
    }

    public void AumentarSalario(double porcentagemDeAumento)
    {
        SalarioBruto += (SalarioBruto * porcentagemDeAumento / 100.0);
    }
    
    public override string ToString()
    {
        return $"Funcionario: {Nome}, R$ {SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture)}";
    }
}