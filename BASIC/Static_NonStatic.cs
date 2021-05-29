using System;

class Contoh
{
    int a; //non static
    static int b = 99; //static 

    public Contoh(int a)
    {
        this.a = a;
    }

    static void Main(string[] args)
    {
        //mengakses static variable menggunakan nama class, dapat di lakukan meskipun class tersebut belum pernah di inisialisasi(dibuat object nya)
        Console.WriteLine("Static Variable b : " +Contoh.b);

        //membuat object(inisialisasi)
        Contoh object1 = new Contoh(100);
        Contoh object2 = new Contoh(200);

        Console.WriteLine("Object 1 = " + object1.a);
        Console.WriteLine("Object 2 = " + object2.a);

    }

}