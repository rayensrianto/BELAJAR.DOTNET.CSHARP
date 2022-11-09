using System;

/*
Generic : konsep untuk membuat parameter yang dinamis, jenis yang di lempar bisa data apapun sesuai yang di input oleh user.
*/

public class ContohSatu
{
    public static bool AreEqual<T>(T value1, T value2)
    {
        return value1.Equals(value2);
    }
}

//Contoh generic class
public class ContohDua<T>
{
    private T GenericMemberVariable;

    public ContohDua(T value)
    {
        GenericMemberVariable = value;
    }

    public T GenericMethod(T GenericParameter)
    {
        System.Console.WriteLine(typeof(T).ToString() +" - "+ GenericParameter);
        System.Console.WriteLine(typeof(T).ToString() +" - "+ GenericMemberVariable);

        return GenericMemberVariable;
    }

    public T GenericProperty {get; set;}
}

public class Program
{
    static void Main(string [] args) 
    {
        bool isEqual1 = ContohSatu.AreEqual<int>(10, 10);
        System.Console.WriteLine(isEqual1);
        bool isEqual2 = ContohSatu.AreEqual<string>("Ryan", "Ryan");
        System.Console.WriteLine(isEqual2);

        ContohDua<int> contohDua = new ContohDua<int>(10);
        contohDua.GenericMethod(200);

        ContohDua<string> contohDuaLagi = new ContohDua<string>("Ryan");
        contohDuaLagi.GenericMethod("Rianto");
    }
}