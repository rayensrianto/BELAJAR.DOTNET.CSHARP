using System;

class Contoh
{
    int x = 100;
    static int y = 200;


    static void Penjumlahan()
    {
        //ini static method, kita bisa akses non-static x menggunakan object, kita bisa akses static y directly dgn nama class
        Contoh obj = new Contoh();

        Console.WriteLine("100 + 200 = " + (obj.x + y));
        Console.WriteLine("100 + 200 = " + (obj.x + Contoh.y));
    }

    void Perkalian()
    {
        //ini non-static method, kita bisa akses non-static members directly menggunakan keyword this
        //kita bisa akses static members directly menggunakan nama class
        Console.WriteLine("100 x 200 = " + (this.x * Contoh.y));
        Console.WriteLine("100 x 200 = " + (x * y));
    }

    static void Main(string[] args)
    {
        //main method adalah static method, penumlahan method juga static, jd bisa direct menggunakan nama class
        Contoh.Penjumlahan();
        Penjumlahan();

        //perkalian method adalah non static, jadi harus di panggil menggunakan object oleh main method yang static
        Contoh obj = new Contoh();
        obj.Perkalian();
    }
}