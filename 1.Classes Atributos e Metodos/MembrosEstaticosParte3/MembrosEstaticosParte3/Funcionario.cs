namespace MembrosEstaticosParte3;
public class Funcionario
{
    public string Nome;
    public double ValorPorHora;
    public double HorasTrabalhadas;

    public Funcionario(string nome, double valorPorHora, double horasTrabalhadas)
    {
        Nome = nome;
        ValorPorHora = valorPorHora;
        HorasTrabalhadas = horasTrabalhadas;
    }

    public double ValorPago()
    {
        return ValorPorHora * HorasTrabalhadas;
    }
}
