//system-defined default constructor.
using System;

class Employee
{
	int eid, eage;
	String eaddress, ename;

	public void Display()
	{
		Console.WriteLine("\nemployee id is: " + eid);
		Console.WriteLine("employee name is: " + ename);
		Console.WriteLine("employee age is: " + eage);
		Console.WriteLine("employee address is: " + eaddress);
	}
}

class Test
{
	public static void Main(string[] args)	
	{
		Employee e1 = new Employee();
		Employee e2 = new Employee();

		e1.Display();
		e2.Display();
		Console.ReadKey();
	}
}