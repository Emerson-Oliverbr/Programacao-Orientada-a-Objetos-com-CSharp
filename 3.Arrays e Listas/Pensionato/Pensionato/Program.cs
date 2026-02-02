namespace Pensionato;
class Program
{
    static void Main(string[] args)
    {
        Student[] student = new Student[10];

        Console.Write("Quantos quartos serão alugados? ");
        int n = int.Parse(Console.ReadLine());        

        for(int i=0; i<n; i+=1)
        {
            Console.WriteLine();
            Console.WriteLine($"Aluguel-{i+1}: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Quarto: ");
            int quarto = int.Parse(Console.ReadLine());
            student[quarto] = new Student(name, email);
        }
        Console.WriteLine();
        Console.WriteLine("Quartos Ocupados:");
        for(int i=0; i<10; i+=1)
        {
            if (student[i] != null)
            {
                Console.WriteLine($"{i} : {student[i]}");
            }
        }
    }
}