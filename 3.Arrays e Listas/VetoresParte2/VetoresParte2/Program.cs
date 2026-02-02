using System.Globalization;

namespace VetoresParte2;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Product[] vect = new Product[n];

        for(int i=0; i<n; i+=1)
        {
            string name = Console.ReadLine();
            double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            vect[i] = new Product { Name = name, Price = price };
        }

        double sum = 0.0;

        for (int i=0; i<n; i+=1)
        {
            sum += vect[i].Price;
        }

        double precoMedio = sum / vect.Length;

        Console.WriteLine($"Preco Médio = R$ {precoMedio.ToString("F2",CultureInfo.InvariantCulture)}");
    }
    
}