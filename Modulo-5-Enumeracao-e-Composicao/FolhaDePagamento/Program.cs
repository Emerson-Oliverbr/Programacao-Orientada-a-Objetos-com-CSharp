using FolhaDePagamento.Entities.Enums;
using FolhaDePagamento.Entities;
using System.Globalization;

namespace FolhaDePagamento;

class Program
{
    static void Main(string[] argumentos)
    {
        Console.Clear();
        Console.Write("Qual o nome do departamento? ");
        string? nomeDepartamento = Console.ReadLine();
        Console.WriteLine("Informe os dados do trabalhador: ");
        Console.Write("Nome: ");
        string? nome = Console.ReadLine();
        Console.Write("Nivel (Junior/Pleno/Senior): ");
        NivelTrabalhador nivel = Enum.Parse<NivelTrabalhador>(Console.ReadLine());
        Console.Write("Salario Base: ");
        double salarioBase = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        Departamento departamento = new Departamento(nomeDepartamento);
        Trabalhador trabalhador = new Trabalhador(nome, nivel, salarioBase, departamento);

        Console.Write("Quantos contratos para esse trabalhador? ");
        int n = Convert.ToInt16(Console.ReadLine());

        for(int index=1; index <=n; index++)
        {
            Console.WriteLine($"Informe os dados do contrato#{index} ");
            Console.Write("Data: (DD/MM/YYYY): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("Valor por hora: ");
            double valorPorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Duração (horas) ");
            int horas = Convert.ToInt16(Console.ReadLine());

            ContratoPorHora contrato = new ContratoPorHora(data, valorPorHora, horas);
            trabalhador.AdicionarContrato(contrato);
        }
        Console.WriteLine();
        Console.Write("Entre com o mes e o ano para calcular os ganhos (MM/AAAA): ");
        string? mesEAno = Console.ReadLine();
        int mes = int.Parse(mesEAno!.Substring(0, 2));
        int ano = int.Parse(mesEAno.Substring(3));

        Console.WriteLine($"Nome: {trabalhador.Nome}");
        Console.WriteLine($"Departamento: {trabalhador.Departamento.Nome}");
        Console.WriteLine($"Ganhos em {mesEAno}: {trabalhador.Renda(ano, mes).ToString("F2",CultureInfo.InvariantCulture)}");
    }
}