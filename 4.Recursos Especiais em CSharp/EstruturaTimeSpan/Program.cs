namespace EstruturaTimeSpan;

class Program
{
    static void Main(string[] args)
    {
        TimeSpan ts1 = new TimeSpan(0, 1, 59);
        Console.WriteLine(ts1);
        Console.WriteLine(ts1.Ticks);
        Console.WriteLine("--------------------");
        TimeSpan ts2 = new TimeSpan();
        Console.WriteLine(ts2);

        TimeSpan ts3 = new TimeSpan(1190000000L);
        Console.WriteLine(ts3);
        Console.WriteLine("--------------------");

        TimeSpan ts4 = new TimeSpan(1, 2, 11, 21);
        Console.WriteLine(ts4);
        Console.WriteLine("--------------------");

        TimeSpan ts5 = new TimeSpan(1, 2, 11, 21, 321);
        Console.WriteLine(ts5);
        Console.WriteLine("--------------------");

        TimeSpan ts6 = TimeSpan.FromDays(1.5);
        Console.WriteLine(ts6);
        Console.WriteLine("--------------------");

        TimeSpan ts7 = TimeSpan.FromHours(1.5);
        Console.WriteLine(ts7);
        Console.WriteLine("--------------------");

        TimeSpan ts8 = TimeSpan.FromMinutes(1.5);
        Console.WriteLine(ts8);
        Console.WriteLine("--------------------");

        TimeSpan ts9 = TimeSpan.FromSeconds(1.5);
        Console.WriteLine(ts9);
        Console.WriteLine("--------------------");

        TimeSpan ts10 = TimeSpan.FromMilliseconds(1.5);
        Console.WriteLine(ts10);
        Console.WriteLine("--------------------");

        TimeSpan ts11 = TimeSpan.FromTicks(9000000L);
        Console.WriteLine(ts11);
        Console.WriteLine("--------------------");

        Console.ReadKey();
    }
}