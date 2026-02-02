namespace LacoForEach;

class Program
{
    static void Main(String[] args)
    {
        string[] vect = new string[] { "Daniela", "Emerson", "Laura" };

        foreach(string obj in vect)
        {
            Console.WriteLine(obj);
        }
    }
}