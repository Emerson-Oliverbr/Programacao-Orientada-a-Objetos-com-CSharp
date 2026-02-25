using System.Globalization;

namespace ExpressaoCondicionalTernaria;

class Program
{
    static void Main(string[] args)
    {
        double preco = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);

        /*double desconto = 0.0; 
        if(preco < 20.0)
        {
            desconto = preco * 0.1;
        }
        else
        {
            desconto = preco * 0.05;
        }*/

        double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
        Console.WriteLine($"Valor de desconto: R${desconto.ToString("F2",CultureInfo.InvariantCulture)}");
    }
}