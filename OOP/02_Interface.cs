using System;

public interface Area
{
	void area(double a, double b);
}

class Rectangle : Area 
{
	public void area(double a, double b)
	{
		double areaRectangle;
		areaRectangle = a * b;
		Console.WriteLine("luas persegi panjang = " + areaRectangle);
	}
}

class Circle : Area 
{	
	static double PI = 3.14;
	public void area(double a, double b)
	{
		double areaCircle;
		areaCircle = PI * a * b;
		Console.WriteLine("luas lingkaran = " + areaCircle);
	}
}

class StartProgram
{
	public static void Main(string[] args)
	{
		Area a = new Rectangle();
		a.area(4, 5);
		a = new Circle();
		a.area(5,0);
	}
}