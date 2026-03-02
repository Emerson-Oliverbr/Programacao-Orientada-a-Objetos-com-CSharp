using System.Globalization;

namespace EstruturaDateTime;

class Program
{
    static void Main(string[] args)
    {
        DateTime d1 = DateTime.Now;
        Console.WriteLine();
        Console.WriteLine($"Tics: {d1.Ticks}");
        Console.WriteLine($"Now: {d1}");
        

        DateTime d2 = new DateTime(2026, 03, 02);
        Console.WriteLine(d2);

        DateTime d3 = new DateTime(2026, 03, 02, 15, 50, 33);
        Console.WriteLine(d3);

        DateTime d4 = new DateTime(2026, 03, 02, 15, 50, 33, 500);
        Console.WriteLine(d4);

        DateTime d5 = DateTime.Today;
        Console.WriteLine(d5);

        DateTime d6 = DateTime.UtcNow;
        Console.WriteLine($"Utc.Now: {d6}");

        DateTime d7 = DateTime.Parse("2026-03-02");
        Console.WriteLine(d7);

        DateTime d8 = DateTime.Parse("2026-03-02 15:58:59");
        Console.WriteLine(d8);

        DateTime d9 = DateTime.Parse("02/03/2016");
        Console.WriteLine(d9);

        DateTime d10 = DateTime.Parse("02/03/2016 15:59:37");
        Console.WriteLine(d10);

        DateTime d11 = DateTime.ParseExact("2026-03-02", "yyyy-MM-dd", CultureInfo.InvariantCulture);
        Console.WriteLine(d11);

        DateTime d12 = DateTime.ParseExact("02/03/2026 16:08:15", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        Console.WriteLine(d12);

        Console.ReadKey();
    }
}

