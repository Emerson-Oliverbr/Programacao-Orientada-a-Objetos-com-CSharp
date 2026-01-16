namespace ExercicioRetangulo;

public class Retangulo
{
    public double Altura;
    public double Largura;

    public double Area()
    {
        return Altura * Largura;
    }

    public double Perimetro()
    {
        return 2.0 * (Altura + Largura);
    }

    public double Diagonal()
    {
        return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
    }
}