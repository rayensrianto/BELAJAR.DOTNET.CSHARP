using System;

//Constructor = spesial method yg ada di class yg bertanggung jawab menginiliasisasi variable2/data member yang ada di class tersebut
//Constructor juga merupakan method yang di panggil secara otomatis saat class di buat objectnya
public class ContohSatu
{
    public int a;
    public int b;

    public ContohSatu()
    {
        b = 100;
    }
}

/*
Ada 5 tipe constructor di c#, yaitu:
    Default Constructor 
    Parameterized Constructor
    Copy Constructor
    Static Constructor
    Private Constructor
*/

// Default Constructor : constructor tanpa parameter
/* Default Constructor - System Defined : default constructor yang tidak di tulis oleh programmer, 
tetapi tetap akan terbuat secara otomatis oleh program untuk menge-set value2 ke data member*/
public class ContohDua
{
    public int Id, Age;
    public string Address, Name;
    public bool IsPermanent;
}

// Default Constructor - User Defined : default constructor yang di tulis secara explicit oleh programmer
public class ContohTiga
{
    public int Id, Age;
    public string Address, Name;
    public bool IsPermanent;

    public ContohTiga()
    {
        Id = 100; 
        Age = 5;
        Name = "Ryan Rianto";
        Address = "Jakarta";
        IsPermanent = true;
    }
}

/*Parameterized Constructor : constructor yang memiliki parameter, jadi data yang di set oleh constructor bisa dinamis tergantung saat pembuatan object pada class tersebut*/
public class ContohEmpat
{
    public ContohEmpat(string Name)
    {
        System.Console.WriteLine("Halo " + Name);
    }
}

public class Program
{
    static void Main(string [] args) 
    {
        ContohSatu contohSatu = new ContohSatu();
        System.Console.WriteLine("Contoh 1 --------------------------------------------");
        System.Console.WriteLine(contohSatu.a); // 0 : otomatis 0 karna diset 0 oleh constructor
        System.Console.WriteLine(contohSatu.b); // 100 : nilai 100 karna constructor nge-set b jadi 100

        ContohDua contohDua = new ContohDua();
        System.Console.WriteLine("Contoh 2 --------------------------------------------");
        Console.WriteLine("Employee Id is:  " + contohDua.Id);
        Console.WriteLine("Employee Name is:  " + contohDua.Name);
        Console.WriteLine("Employee Age is:  " + contohDua.Age);
        Console.WriteLine("Employee Address is:  " + contohDua.Address);
        Console.WriteLine("Is Employee Permanent:  " + contohDua.IsPermanent);

        ContohTiga contohTiga = new ContohTiga();
        System.Console.WriteLine("Contoh 3 --------------------------------------------");
        Console.WriteLine("Employee Id is:  " + contohTiga.Id);
        Console.WriteLine("Employee Name is:  " + contohTiga.Name);
        Console.WriteLine("Employee Age is:  " + contohTiga.Age);
        Console.WriteLine("Employee Address is:  " + contohTiga.Address);
        Console.WriteLine("Is Employee Permanent:  " + contohTiga.IsPermanent);

        System.Console.WriteLine("Contoh 3 --------------------------------------------");
        ContohEmpat contohEmpat = new ContohEmpat("Ryan");
    }
}
