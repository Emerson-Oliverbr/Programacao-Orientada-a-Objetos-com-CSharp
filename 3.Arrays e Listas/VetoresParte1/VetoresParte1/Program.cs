using System.Globalization;

namespace VetoresParte1;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        double[] valores = new double[n];

        for(int i=0; i<n; i++)
        {
            valores[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        }

        double alturaMedia = 0.0;
        for (int i=0; i<n; i++)
        {
            alturaMedia += valores[i] / n;
        }
        Console.WriteLine($"Altura Média = {alturaMedia.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}