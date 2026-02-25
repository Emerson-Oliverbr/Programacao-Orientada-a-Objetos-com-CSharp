namespace ExercicioMatriz;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[,] mat = new int[n,n];

        for (int i = 0; i<n; i++) // Lê as linhas
        {
            string[] valores = Console.ReadLine().Split(' ');
            for(int j=0; j<n; j++) // Lê as Colunas
            {
                mat[i, j] = Convert.ToInt16(valores[j]);
            }           
        }
        Console.WriteLine("Diagonal principal");

        for(int i=0; i<n; i++)
        {
            Console.Write($"{mat[i, i]} ");
        }
        Console.WriteLine();
        Console.WriteLine("Numeros Negativos");

        int quantidadeDeNegativos = 0;
        for (int i = 0; i < n; i++)
        {
           for(int j=0; j<n;j++)
            {                
                if (mat[i,j] <0)
                {
                    quantidadeDeNegativos += 1;
                    Console.Write($"{mat[i, j]} ");
                }                
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Quantidade de numeros negativos: {quantidadeDeNegativos}");
    }
}