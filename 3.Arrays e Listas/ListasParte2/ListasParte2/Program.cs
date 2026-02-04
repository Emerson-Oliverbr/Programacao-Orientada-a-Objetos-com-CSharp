using System.Collections.Generic;

namespace ListasParte2;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();

        list.Add("Daniela"); //0 - Add() insere um elemento no final da lista
        list.Add("Emerson"); //1
        list.Add("Laura");   //2
        list.Add("Maria");
        list.Add("Marco");
        list.Add("Anna");
        list.Insert(2, "Lorenzzo"); // 3 Insert() insere um elemento indicando a posição
        
        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine($"Contagem da Lista: {list.Count}"); // Mostra o tamanho da Lista
        Console.WriteLine("----------------------------------------------");

        string s1 = list.Find(x => x[0] == 'D'); // Expresão lambda Objeto x tal-que x na posição 0 jega igual ao caractere D

        Console.WriteLine($"First 'D' {s1}");
        Console.WriteLine("----------------------------------------------");

        string s2 = list.FindLast(x => x [0] == 'L');

        Console.WriteLine($"Last 'L' {s2}");
        Console.WriteLine("----------------------------------------------");
        int posicao1 = list.FindIndex(x => x[0] == 'L');
        Console.WriteLine($"Primeira posição comecando com  'L': {posicao1}");

        int posicao2 = list.FindLastIndex(x => x[0] == 'L');
        Console.WriteLine($"Primeira posição comecando com  'L': {posicao2}");

        List<string> list2 = list.FindAll(x => x.Length == 5);
        Console.WriteLine("----------------------------------------------");

        foreach(string obj in list2)
        {
            Console.WriteLine(obj);
        }
        Console.WriteLine("----------------------------------------------");

        //Removendo elementos da lista

        list.Remove("Laura");

        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }

        list.RemoveAll(x => x[0] == 'L');

        Console.WriteLine("----------------------------------------------");

        //Removendo todos elementos da lista que começa com a letra L

        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }
        Console.WriteLine("----------------------------------------------");
        //Removendo um elemento pela posição 

        list.RemoveAt(4);
        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }

        Console.WriteLine("----------------------------------------------");
        //Removendo elementos a partir de uma contagem 

        list.RemoveRange(0, 2);
        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }

        Console.ReadKey();
    }    
}