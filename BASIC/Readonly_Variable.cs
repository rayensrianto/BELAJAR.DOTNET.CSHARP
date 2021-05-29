class ContohReadOnly
{
    public readonly int nomor = 5;
}

class Program
{
    static void Main(string[] args)
    {
        ContohReadOnly object1 = new ContohReadOnly();
        System.Console.WriteLine(object1.nomor);
    }
}