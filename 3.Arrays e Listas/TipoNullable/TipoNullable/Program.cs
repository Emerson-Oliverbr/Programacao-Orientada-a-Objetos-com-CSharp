using System.Globalization;

namespace TipoNullable;

class Program
{
    static void Main(string[] args)
    {
        //double x = null; =  Errado
        //Nullable<double> x = null; certo porém existe uma maneira mais indicada

        double? x = null;
        double? y = 10.0;

        Console.WriteLine(x.GetValueOrDefault());
        Console.WriteLine(y.GetValueOrDefault());
        Console.WriteLine();
        Console.WriteLine(x.HasValue);
        Console.WriteLine(y.HasValue);
        Console.WriteLine();
        //Console.WriteLine(x.Value);
        Console.WriteLine(y.Value);

        double a = x ?? 5;
        double b = y ?? 5;
        Console.WriteLine();
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}