namespace ModificadorRefOut;

class Program
{
    static void Main(string[] args)
    {
        /* 
         * int a = 10;

         Calculadora.Triplo(ref a);
         Console.WriteLine(a); // Saida = 30 
        */

        int a = 15;
        int triple;

        Calculadora.Triplo(a, out triple);
        Console.WriteLine(triple);
    }
}