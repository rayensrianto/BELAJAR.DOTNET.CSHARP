using System;

namespace AutoImplementedPorperty
{
    class Test
    {
        public int A { get; set; }
        public int B { get; set; }

        public int Add()
        {
            return A + B;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();
            obj.A = 100;
            obj.B = 200;
            Console.WriteLine(obj.Add());
        }
    }
}