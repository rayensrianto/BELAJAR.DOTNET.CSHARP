using System;

//Generic Constraint : menentukan tipe data yang bisa di parsing ke generic class/method

//Contoh sebuah generic class yang menggunakan generic constraint class
public class ContohSatu<T> where T : class
{
    public T Message;
    public void GenericMethod(T Param1, T Param2)
    {
        System.Console.WriteLine("Message : " + Message);
        System.Console.WriteLine("Param 1 : " + Param1);
        System.Console.WriteLine("Param 2 : " + Param2);
    }
}

public class Employee
{
    public string Name { get; set; }
    public string Location { get; set; }

}

//contoh 2: contoh multiple generic constraint
public class ContohDua<T, X> where T : class where X : struct
{
    public T Message;
    public void GenericMethod(T Param1, X Param2)
    {
        System.Console.WriteLine("Message : " + Message);
        System.Console.WriteLine("Param 1 : " + Param1);
        System.Console.WriteLine("Param 2 : " + Param2);
    }
}

public class Program
{
    static void Main(string [] args) 
    {
        ContohSatu<string> stringClass = new ContohSatu<string>();
        stringClass.Message = "Welcome from stringClass";
        stringClass.GenericMethod("Ryan", "Rianto");

        ContohSatu<Employee> employeeClass = new ContohSatu<Employee>();
        Employee emp1 = new Employee() { Name = "Anurag", Location = "Bhubaneswar" };
        Employee emp2 = new Employee() { Name = "Mohanty", Location = "Cuttack" };
        Employee emp3 = new Employee() { Name = "Sambit", Location = "Delhi" };

        employeeClass.Message = emp1;
        employeeClass.GenericMethod(emp2, emp3);
        
        //ContohSatu<int> test = new ContohSatu<int>(); // <-- error saat di compile, karna int bukan sebuah class

        //buat object untuk multiple generic constraint
        ContohDua<string, int> contohDua = new ContohDua<string, int>();
        contohDua.Message = "Bissmillah";
        contohDua.GenericMethod("Alhamdulillah", 99999999);
    }
}