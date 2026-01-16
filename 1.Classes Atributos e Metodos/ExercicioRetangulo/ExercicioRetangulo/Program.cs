using System.Globalization;

namespace ExercicioRetangulo;

class Program
{
    static void Main(string[] args)
    {
        Retangulo retangulo = new Retangulo();
        
        Console.WriteLine("Entre com as medidas de largura e altura do retangulo: ");
        retangulo.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        retangulo.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.WriteLine($"AREA = {retangulo.Area().ToString("F2",CultureInfo.InvariantCulture)}");
        Console.WriteLine($"PERIMETRO = {retangulo.Perimetro().ToString("F2",CultureInfo.InvariantCulture)}");
        Console.WriteLine($"DIAGONAL = {retangulo.Diagonal().ToString("F2",CultureInfo.InvariantCulture)}");
    }
}