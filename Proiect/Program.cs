using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LOG IN: ");
            Console.WriteLine("EMAIL/USER: ");
            string  emailUserAngajat= Console.ReadLine();
            Console.WriteLine("PAROLA: ");
            string  parolaAngajat = Console.ReadLine();
            Angajat a1 = new Angajat(emailUserAngajat, parolaAngajat);
            Console.WriteLine("LOGARE COMPLETA!");
            if (Angajat.PrezentAngajat == 1 && a1 != null)
            {
                Angajat.NumeAngajat an1 = new Angajat.NumeAngajat("Popescu", "Andrei");
                Console.WriteLine(an1.NumeComplte);
            }

            if (Angajat.PrezentAngajat == 2)
            {
                Console.WriteLine("Introduceti numele clientului:");
                string NUME = Console.ReadLine();
                Console.WriteLine("Introduceti prenumele clientului:");
                string PRENUME = Console.ReadLine();
                Console.WriteLine("Introduceti CNP-ul clientului:");
                string CNP = Console.ReadLine();
                Console.WriteLine("Introduceti suma de care dispune clientul:");
                double SumaDisponibila;
                if (!double.TryParse(Console.ReadLine(), out SumaDisponibila))
                {
                    Console.WriteLine("Eroare la citire");
                }
                Console.WriteLine("Introduceti perioada de inchirere(zile) a masinii:");
                int Perioada;
                if (!int.TryParse(Console.ReadLine(), out Perioada))
                {
                    Console.WriteLine("Eroare la citire");
                }
                Client c1 = new Client(NUME, PRENUME, CNP, SumaDisponibila, Perioada);
                string s1 = c1.Info();
                Console.WriteLine(s1);
            }



            if (Client.interesat == 1)
            {
                Masina m1 = new Masina("Audi,A4,negru,300,2007");
                m1.afisare();
                Masina m2 = new Masina("VW,Golf V,alb,300,2007");
                m2.afisare();
                Masina m3 = new Masina("VW,Golf VI,albastru,400,2009");
                m3.afisare();
                Masina m4 = new Masina("Audi,A5,gri,350,2009");
                m4.afisare();
                Masina m5 = new Masina("Dacia,Logan,alb,200,2009");
                m5.afisare();

            }
            Console.ReadKey();
        }
    }
}
