using System.Globalization;

namespace ContaBancaria;

class Program
{
    static void Main(string[] args)
    {
        ContaSalario conta;
        
        Console.Write("Entre com número da conta: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Entre com titular da conta: ");
        string titular = Console.ReadLine();
        Console.Write("Haverá depósito inicial (s/n)? ");
        char resposta = char.Parse(Console.ReadLine());

        if (resposta == 's' || resposta == 'S')
        {
            Console.Write("Valor do deposito? ");
            double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta = new ContaSalario(numero, titular, depositoInicial);
        }
        else
        {
            conta = new ContaSalario(numero, titular);
        }
        Console.WriteLine("Dados da Conta: ");
        Console.WriteLine($"{conta}");

        Console.Write("Entre com um valor para depósito: ");
        double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        conta.Deposito(deposito);
        Console.WriteLine("Dados atualizados da Conta: ");
        Console.WriteLine($"{conta}");
        Console.Write("Entre com um valor para saque: ");
        double saque = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        conta.Saque(saque);
        Console.WriteLine("Dados atualizados da Conta: ");
        Console.WriteLine($"{conta}");
    }
}