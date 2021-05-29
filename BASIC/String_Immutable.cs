using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string str = "";
        int test = 0;
        Console.WriteLine("Loop Started");

        var stopwatch = new Stopwatch();

        stopwatch.Start();
        for (int i = 0; i < 30000000; i++)
        {
            test = test +1;
        }
        stopwatch.Stop();

        Console.WriteLine("Loop ended");
        Console.WriteLine("Loop execution Time In MS :" + stopwatch.ElapsedMilliseconds);
    }
}