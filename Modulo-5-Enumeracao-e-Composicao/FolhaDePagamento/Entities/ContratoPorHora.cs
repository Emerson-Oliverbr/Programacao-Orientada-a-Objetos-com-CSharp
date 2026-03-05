namespace FolhaDePagamento.Entities;

public class ContratoPorHora
{
    public DateTime Data { get; set; }
    public double ValorPorHora { get; set; }
    public int Horas { get; set; }

    public ContratoPorHora() { }

    public ContratoPorHora(DateTime data, double valorPorHora, int horas)
    {
        Data = data;
        ValorPorHora = valorPorHora;
        Horas = horas;
    }

    public double ValorTotal()
    {
        return ValorPorHora * Horas;
    }
}
