using System.Globalization;

namespace MembrosEstaticos;

class Program {
    static double Pi = 3.14;
    static void Main(string[] arggs)
    {
        Console.Write("Digite o valor do raio: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double circ = Circunferencia(raio);
        double volume = Volume(raio);

        Console.WriteLine($"Circunferencia: {circ.ToString("F2",CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Pi: {Pi.ToString("F2", CultureInfo.InvariantCulture)}");
    }

    static double Volume(double r)
    {
        return 4.0 / 3 * Pi * Math.Pow(r, 3.0);
    }

    static double Circunferencia(double r)
    {
        return 2.0 * Pi * r;
    }
}