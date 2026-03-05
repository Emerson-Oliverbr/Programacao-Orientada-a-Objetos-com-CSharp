using System.Collections.Generic;
using FolhaDePagamento.Entities.Enums;

namespace FolhaDePagamento.Entities;

public class Trabalhador
{
    public string? Nome { get; set; }
    public NivelTrabalhador Nivel { get; set; }
    public double SalarioBase { get; set; }
    public Departamento Departamento { get; set; }
    public List<ContratoPorHora> Contratos { get; set; } = new List<ContratoPorHora>();

    public Trabalhador() { }

    public Trabalhador(string? nome, NivelTrabalhador nivel, double salarioBase, Departamento departamento)
    {
        Nome = nome;
        Nivel = nivel;
        SalarioBase = salarioBase;
        Departamento = departamento;
    }

    public void AdicionarContrato(ContratoPorHora contrato)
    {
        Contratos.Add(contrato);
    }

    public void RemoverContrato(ContratoPorHora contrato)
    {
        Contratos.Remove(contrato);
    }

    public double Renda(int ano, int mes)
    {
        double soma = SalarioBase;

        foreach (ContratoPorHora contrato in Contratos)
        {
            if (contrato.Data.Year == ano && contrato.Data.Month == mes)
            {
                soma += contrato.ValorTotal();
            }
        }
        return soma;
    }
}
