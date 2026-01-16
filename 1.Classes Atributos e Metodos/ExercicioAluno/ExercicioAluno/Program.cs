using System.Globalization;

namespace ExercicioAluno;

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno();

        Console.Write("Nome do aluno: ");
        aluno.Nome = Console.ReadLine();
        Console.WriteLine("Digite as três notas do aluno:");
        aluno.Nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        aluno.Nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        aluno.Nota3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.WriteLine($"NOTA FINAL = {aluno.Media().ToString("F2",CultureInfo.InvariantCulture)}");

        if (aluno.Media() > 60.0)
        {
            Console.WriteLine("APROVADO");
        }
        else
        {
            Console.WriteLine($"NOTA FINAL = {aluno.Media().ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine("REPROVADO");
            Console.WriteLine($"FALTARAM {aluno.NotaRestante().ToString("F2",CultureInfo.InvariantCulture)} Pontos");
        }
    }
}