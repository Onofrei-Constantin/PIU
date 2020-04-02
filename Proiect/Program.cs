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
            //Instantierea unei Masini utilizand constructorul fara paramatrii

            Console.WriteLine("Instantierea unui Medicament utilizand constructorul fara paramatrii");
            Masina masina = new Masina();
            string buf = masina.Afisare();
            Console.WriteLine(buf);
            


            //Instantierea unei Masini utilizand constructorul cu parametrii

            Console.WriteLine("Instantierea unui Medicament utilizand constructorul cu parametrii");
            Masina masina1 = new Masina(2007, 4500, "Andrei Popa", "Onofrei Constantin", "AUDI A4","Negru","Aer conditionat,navigatie","02.04.2020");
            string buf1 = masina1.Afisare();
            Console.WriteLine(buf1);

            //Instantierea unei Masini prin intermediul unui constructor care primeste ca parametru un sir

            Console.WriteLine("Instantierea unui Medicament prin intermediul unui constructor care primeste ca parametru un sir");
            Masina masina2 = new Masina("2009 5000 Vieru_Andrei Onofrei_Constantin VW_Golf_V Gri Aer_conditionat,navigatie 02.04.2020");
            string buf2 = masina2.Afisare();
            Console.WriteLine(buf2);

            //Compara doua masini
            if (masina1.ComparaDouaMasini(masina2))
                Console.WriteLine("Masina {0} a vazatorului {1} si masina {2} vanzatorului {} sunt identice", masina1.Tip, masina1.NumeVanzator,masina2.Tip,masina2.NumeVanzator);
            else
                Console.WriteLine("Cele doua medicamente comparate nu sunt la fel");

            //Citire masina de la tastatura

            Console.WriteLine("Citire date despre masina de la tastatura:");
            Masina masina3 = new Masina();
            masina3 = CitireMasinaTastatura();
            string buf3 = masina3.ConversieLaSir();
            Console.WriteLine(buf3);

            Console.ReadKey();
        }
        public static Masina CitireMasinaTastatura()
        {
            Masina masinaTastatura = new Masina();

            Console.WriteLine("Numele vazatorului : ");
            masinaTastatura.NumeVanzator = Console.ReadLine();

            Console.WriteLine("Numele cumparatorului : ");
            masinaTastatura.NumeCumparator = Console.ReadLine();

            Console.WriteLine("Model si tip : ");
            masinaTastatura.Tip = Console.ReadLine();

            Console.WriteLine("Pret : ");
            masinaTastatura.Pret = float.Parse(Console.ReadLine());

            Console.WriteLine("Anul Fabricatie : ");
            masinaTastatura.AnFabricatie = int.Parse(Console.ReadLine());

            Console.WriteLine("Optiuni : ");
            masinaTastatura.Optiuni = Console.ReadLine();

            Console.WriteLine("Data tranzactiei : ");
            masinaTastatura.DataTranzactie = Console.ReadLine();

            Console.WriteLine("Culoare : ");
            masinaTastatura.Culoare = Console.ReadLine();

            return masinaTastatura;
        }

    }
}
