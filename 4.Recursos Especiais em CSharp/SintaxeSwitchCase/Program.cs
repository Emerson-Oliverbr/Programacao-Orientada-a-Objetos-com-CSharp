namespace SintaxeSwitchCase;

class Program
{
    static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());

        string dia = " ";

        switch (x)
        {
            case 1:
                dia = "Domingo";
                break;
            case 2:
                dia = "Segunda-Feira";
                break;
            case 3:
                dia = "Terça-Feira";
                break;
            case 4:
                dia = "Quarta-Feira";
                break;
            case 5:
                dia = "Quinta-Feira";
                break;
            case 6:
                dia = "Sexta-Feira";
                break;
            case 7:
                dia = "Sabado";
                break;
            default:
                dia = "Dia invalido";
                break;
        }
        Console.WriteLine($"Dia: {dia}");
    }
}