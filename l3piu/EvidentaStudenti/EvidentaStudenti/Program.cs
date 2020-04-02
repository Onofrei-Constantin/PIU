using LibrarieEntitati;
using System;


namespace ManagementStudenti
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Ionescu");
            //s.SetNote("");
            Console.WriteLine(s.ConversieLaSir());
            Console.ReadKey();
        }
    }
}
