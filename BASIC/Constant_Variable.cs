class ContohConst
{
    //kita harus inisialisasi/assign sebuah value ke constant variable, jika tidak maka akan error
    public const int number = 4;
}

class Program
{
    static void Main(string[] args)
    {
        //karna const variable secara default adalah static, jd bisa akses secara langsung tanpa object
        System.Console.WriteLine(ContohConst.number);
    }
}