namespace ModificadorParams;

class Program
{
    static void Main(string[] args)
    {
        //int s1 = Calculadora.Soma(2, 3);
        //int s2 = Calculadora.Soma(3, 6, 1);

        //int s1 = Calculadora.Soma(new int[] { 2, 3 });
        //int s2 = Calculadora.Soma(new int[] { 2, 3, 5 });

        int s1 = Calculadora.Soma(2, 3 );
        int s2 = Calculadora.Soma( 2, 3, 5 );

        Console.WriteLine(s1);
        Console.WriteLine(s2); 
    }
}