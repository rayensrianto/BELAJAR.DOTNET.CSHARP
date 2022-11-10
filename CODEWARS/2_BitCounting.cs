using System;
using System.Linq;

public class Kata
{
    public static int CountBits(int n)
    {
        string binary = Convert.ToString(n, 2);
        var result = binary.Count(x => x == '1');
        return result;
    }

    public static void Main(string[] args)
    {
        System.Console.WriteLine(Kata.CountBits(1234));
    }
}