using System;

/*
Abstraction mirip dengan encapsulation, beda nya kalo encapsulation menghindari data bisa di akses langsung dari luar,
tapi kalo abstraction menyembunyikan proses yang terjadi di belakang layar dari sebuah proses.
Biasanya abstraction di implement menggunakan interface atau abstrac class.
*/

public interface IBank
{
    void CheckBalance();
    void WithdrawMoney();
}

public class BCA : IBank
{
    public void CheckBalance() { System.Console.WriteLine("BCA Check Balance"); }
    public void WithdrawMoney() { System.Console.WriteLine("BCA Withdraw Money"); }
}

public class BRI : IBank
{
    public void CheckBalance() { System.Console.WriteLine("BRI Check Balance"); }
    public void WithdrawMoney() {System.Console.WriteLine("BRI Withdraw Money"); }
}

public class BankFactory
{
    public static IBank GetBankObject(string bankName)
    {
        IBank BankObject = new BRI();

        if (bankName == "BCA") {
            BankObject = new BCA();
        }

        return BankObject;
    }
}


public class Program
{
    static void Main(string [] args) 
    {
        System.Console.WriteLine("BANK BCA");
        IBank BCA = BankFactory.GetBankObject("BCA");
        BCA.CheckBalance();
        BCA.WithdrawMoney();

        System.Console.WriteLine("BANK BRI");
        IBank BRI = BankFactory.GetBankObject("BRI");
        BRI.CheckBalance();
        BRI.WithdrawMoney();
    }
}