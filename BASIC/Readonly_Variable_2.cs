class ClassReadOnly
{
    public readonly int nomor = 5;

    public ClassReadOnly()
    {
        nomor = 50;
    }

    public ClassReadOnly(bool isAnotherInstance)
    {
        nomor = 100;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ClassReadOnly object1 = new ClassReadOnly();
        System.Console.WriteLine(object1.nomor);

        ClassReadOnly object2 = new ClassReadOnly(true);
        System.Console.WriteLine(object2.nomor);
    }
}