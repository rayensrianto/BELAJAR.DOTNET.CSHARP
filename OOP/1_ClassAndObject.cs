using System;

public class Program
{
    static void Main(string [] args) 
    {
        //buat object dari clas calculator
        Calculator objectCalculator = new Calculator();
        System.Console.WriteLine(objectCalculator.Sum(5,5));
        System.Console.WriteLine(objectCalculator.Multiply(5,5));
    }
}

// class calculator 
public class Calculator
{
    public int Sum(int a, int b)
    {
        return a + b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}