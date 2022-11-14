using System;
/*
Anonymous method adalah method yang tidak memilikin nama method dan dibuat menggunakan delegate
*/

public class Program
{
    public delegate void petanim(string pet);

    public delegate void Print(int value);

    static void Main(string [] args) 
    {
    
       //sample 1
        petanim p = delegate(string mypet) {
            System.Console.WriteLine("My favorite pet is " + mypet);
        };
        p("dog");

        //sample 2 : anonymous function can access variable
        int i = 99;
        Print print = delegate(int val) {
            val += i;
            System.Console.WriteLine("Sample 2 | value " + val);
        };
        print(100);
    }
}