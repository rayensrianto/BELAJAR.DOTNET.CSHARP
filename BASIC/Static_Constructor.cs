using System;

namespace Static_Constructor
{
    class Contoh
    {
        static Contoh()
        {
            Console.WriteLine("static constructor di panggil");
        }

        public Contoh()
        {
            Console.WriteLine("non-static constructor di panggil");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Method main di panggil");
            Contoh obj = new Contoh();
            Contoh obj2 = new Contoh();
        }
    }
}