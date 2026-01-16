using System;
using System.Globalization;

namespace ExemploSemPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triangulo X: ");
            double xA = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double xB = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double xC = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            double yA = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double yB = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double yC = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = (Math.Sqrt(p * (p-xA) * (p-xB) * (p-xC)));
            
            p = (yA + yB + yC) / 2.0;
            double areaY = (Math.Sqrt(p * (p-yA) * (p-yB) * (p-yC)));

            Console.WriteLine("Area de X = " + areaX.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4",CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: X ");
            }
            else
            {
                Console.WriteLine("Maior area: Y");
            }
        }
    }
}