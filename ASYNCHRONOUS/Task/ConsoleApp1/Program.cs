using System;
using System.Threading.Tasks;

/*
Saat kita menggunaka Asynchronous method, kita dapat membuat return dari salah satu tipe data berikut:
1. Task dan Task<T>
2. ValueTask dan ValueTask<T>

Task : tanda bahwa sebuah operasi belum tentu selesai sekarang juga, tetapi pasti akan selesai nanti nya.
Task vs Task<T> : Task untuk method yang tidak perlu return value, Task<T> untuk method yang perlu return value
*/

public class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Main method started...");

    }

    public async static void SomeMethod()
    {
        System.Console.WriteLine("Method started....");
        Wait();
        System.Console.WriteLine("\nSome method end");
    }

    public async static Task Wait()
    {
        await Task.Delay(TimeSpan.FromSeconds(2));
        System.Console.WriteLine("\n2s seconds wait completed\n");
    }
}