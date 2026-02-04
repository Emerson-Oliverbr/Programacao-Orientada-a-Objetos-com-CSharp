using System.Globalization;
using System.Collections.Generic;

namespace ExercicioFuncionario;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Quantos funcionários serão registrados? ");
        int n = int.Parse(Console.ReadLine());

        List<Funcionario> list = new List<Funcionario>();

        for (int i = 0; i < n; i += 1)
        {
            Console.WriteLine();
            Console.WriteLine($"Funcionario: {i + 1} ");
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salario: ");            
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            
            list.Add(new Funcionario(id, nome, salario));
        }

        Console.WriteLine();
        Console.Write("Digite o ID do funcionário que receberá o aumento salarial: ");
        int idDeBusca = int.Parse(Console.ReadLine());

        Funcionario funcionario = list.Find(x => x.Id == idDeBusca);

        if (funcionario != null)
        {
            Console.Write("Digite a porcentagem: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);
        }
        else
        {
            Console.WriteLine("Esse Id não existe!");
        }

        Console.WriteLine();
        Console.WriteLine("Lista de Funcionarios Atualizada:");

        foreach (Funcionario obj in list)
        {
            Console.WriteLine(obj);
        }

        Console.ReadLine();
    }
}