using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Facultate UEO = new Facultate("UEO");
            UEO.Students = new Student[] {new Student("Afloarei", "David", new DateTime(2002, 01, 01), "12345678"),
                              new Student("Andrei", "Daniel", new DateTime(2002, 01, 02), "87654321"),
                              new Student("Ulici", "Raul", new DateTime(2002, 10, 12), "00000000")};


            Console.WriteLine(UEO.Index("87654321")); // indexator
        }
    }
}
