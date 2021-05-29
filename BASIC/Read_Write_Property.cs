using System;

namespace ReadWriteProperty
{
    public class Contoh
    {
        private int _KarywanID;
        private string _KaryawanNama;

        public int KaryawanID
        {
            set {
                _KarywanID = value;
            }
            get {
                return _KarywanID;
            }
        }

        public string KaryawanNama
        {
            set {
                _KaryawanNama = value;
            }
            get {
                return _KaryawanNama;
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Contoh obj = new Contoh();
            obj.KaryawanID = 0001;
            obj.KaryawanNama = "Ryan";
            Console.WriteLine("ID " + obj.KaryawanID);
            Console.WriteLine("Name " + obj.KaryawanNama);
        }
    }
}