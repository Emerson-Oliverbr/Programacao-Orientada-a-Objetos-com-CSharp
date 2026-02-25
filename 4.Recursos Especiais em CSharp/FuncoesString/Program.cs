using System;

namespace FuncoesString;

class Program
{
    static void Main(string[] args)
    {
        var original = "abcde FGHIJ ABC abc DEFG     ";
        string s1 = original.ToUpper();
        string s2 = original.ToLower();
        string s3 = original.Trim();

        Console.WriteLine($"Original: -{original} -");
        Console.WriteLine($"S1 ToUpper: -{s1} -");
        Console.WriteLine($"S2 ToLower: -{s2} -");
        Console.WriteLine($"S3 ToTrim: -{s3} -");

        int n1 = original.IndexOf("bc");
        int n2 = original.LastIndexOf("bc");

        Console.WriteLine($"IndexOf ('bc') -{n1} -");
        Console.WriteLine($"IndexOf ('bc') -{n2} -");

        string s4 = original.Substring(3);
        string s5 = original.Substring(3, 5);
        string s6 = original.Replace('a', '#');
        string s7 = original.Replace("abc", "^_^");

        bool b1 = String.IsNullOrEmpty(original);
        bool b2 = String.IsNullOrWhiteSpace(original);

        Console.WriteLine($"Substring(3) -{s4} -");
        Console.WriteLine($"Substring(3, 5) -{s5} -");
        Console.WriteLine($"Replace -{s6} -");
        Console.WriteLine($"Replace -{s7} -");
        Console.WriteLine($"String.IsNullOrEmpty: {b1}");
        Console.WriteLine($"String.IsNullOrWhiteSpace: {b1}");

        Console.ReadKey();
    }
}