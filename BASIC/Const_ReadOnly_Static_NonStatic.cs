using System;

class Contoh
{
    int x; //non-static
    static int y = 5; //static
    const float PI = 3.14f; //const variable
    readonly bool flag; //read only

    public Contoh(int x, bool flag)
    {
        this.x = x;
        this.flag = flag;
    }


    static void Main(string[] args)
    {
        Console.WriteLine(Contoh.y);
        Console.WriteLine(Contoh.PI);
        Contoh obj1 = new Contoh(50, true);
        Contoh obj2 = new Contoh(10, false);
        Console.WriteLine(obj1.x +" "+ obj1.flag);
        Console.WriteLine(obj2.x +" "+ obj2.flag);
    }
}