using System;
/*
Anonymous method adalah method yang tidak memilikin nama method dan dibuat menggunakan delegate
*/

public class Program
{
    public delegate void petanim(string pet);

    static void Main(string [] args) 
    {
        petanim p = delegate(string mypet) {
            System.Console.WriteLine("My favorite pet is " + mypet);
        };
        p("dog");
    }
}