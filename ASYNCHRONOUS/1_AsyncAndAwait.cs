using System;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    static void Main(string [] args) 
    {
        // System.Console.WriteLine("Contoh Satu-------------------------");

        // System.Console.WriteLine("Main Method Started");
        // ContohSatu();
        // System.Console.WriteLine("Main Method End");

        // System.Console.WriteLine("Contoh Satu-------------------------");

        System.Console.WriteLine("Contoh Dua-------------------------");

        System.Console.WriteLine("Main Method Started");
        ContohDua();
        System.Console.WriteLine("Main Method End");
        
        System.Console.WriteLine("Contoh Dua-------------------------");

        Console.ReadKey();
    }

    // contoh synchronous, output nya sesuai urutan code nya.
    public static void ContohSatu()
    {
        System.Console.WriteLine("ContohSatu method started....");

        Thread.Sleep(TimeSpan.FromSeconds(10));
        System.Console.WriteLine("\n");
        System.Console.WriteLine("ContohSatu method end.");
    }

    public async static void ContohDua()
    {
        System.Console.WriteLine("ContohDua method started....");

        await Task.Delay(TimeSpan.FromSeconds(10));
        System.Console.WriteLine("\n");
        System.Console.WriteLine("ContohDua method end.");
    }
}