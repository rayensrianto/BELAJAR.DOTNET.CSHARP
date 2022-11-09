using System;

/*
Encapsulation : konsep menyembunyikan data yang penting pada sebuah class agar tidak bisa di akses secara langsung dari luar class, dan menyediakan feature khusus untuk mengakses data tersebut dari luar class dimana feature khusus ini biasanya berupa method dan biasanya terdapat beberapa validasi juga untu mengakses data penting tersebut.
*/

public class ContohSatu
{
    private double _Amount;
    public double Amount
    {
        get { return _Amount; }
        set 
        {
            if (value < 0) 
            {
                throw new Exception("Please pass a positive value");
            }
            else
            {
                _Amount = value;    
            }
        }
    }


}

public class Program
{
    static void Main(string [] args) 
    {
        try
        {
            ContohSatu contohSatu = new ContohSatu();
            
            contohSatu.Amount = 10;
            System.Console.WriteLine(contohSatu.Amount);

            contohSatu.Amount = -10;
            System.Console.WriteLine(contohSatu.Amount);

        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }
}
