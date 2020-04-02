using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


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
            ScriereFisier(masina1);

            //Instantierea unei Masini prin intermediul unui constructor care primeste ca parametru un sir

            Console.WriteLine("Instantierea unui Medicament prin intermediul unui constructor care primeste ca parametru un sir");
            Masina masina2 = new Masina("2009 Vieru_Andrei Onofrei_Constantin VW_Golf_V Gri Aer_conditionat,navigatie 02.04.2020 5000");
            string buf2 = masina2.Afisare();
            Console.WriteLine(buf2);
            ScriereFisier(masina2);


            //Compara doua masini
            if (masina1.ComparaDouaMasini(masina2))
                Console.WriteLine("Masina {0} a vazatorului {1} si masina {2} a vanzatorului {} sunt identice", masina1.Tip, masina1.NumeVanzator,masina2.Tip,masina2.NumeVanzator);
            else
                Console.WriteLine("Cele doua masini comparate nu sunt la fel");

            //Citire masina de la tastatura

            Console.WriteLine("Citire date despre masina de la tastatura:");
            Masina masina3 = new Masina();
            masina3 = CitireMasinaTastatura();
            string buf3 = masina3.ConversieLaSir();
            Console.WriteLine(buf3);
            ScriereFisier(masina3);

            Console.WriteLine("Citire date despre masina de la tastatura:");
            Masina masina10 = new Masina();
            masina10 = CitireMasinaTastatura();
            string buf10 = masina10.ConversieLaSir();
            Console.WriteLine(buf10);
            ScriereFisier(masina10);


            //Citire unei masini din fisier

            Console.WriteLine("Citire masini din fisier");
            int nrMasini;
            Masina[] masina4 = CitireFisier(out nrMasini);

            for (int i = 0; i < nrMasini; i++)
            {
                string buf4 = masina4[i].Afisare();
                Console.WriteLine(buf4);
                ScriereFisier(masina4[i]);
            }

            //Folosirea Enumerari Culoare Masina
            Console.WriteLine("Alegeti culoarea pe care o doresti :");
            string[] culoare = { "Rosu", "Negru", "Gri", "Masini gasite:" };
            Console.WriteLine("[1]{0}\n[2]{1}\n[3]{2}\n", culoare[0], culoare[1], culoare[2]);
            Console.Write("Alege:");
            int optiune = int.Parse(Console.ReadLine());

            if (optiune == (int)CuloareMasina.Rosu)
                Console.WriteLine("{0}\n{1}\n{2}", culoare[3], buf3,buf10);

            if (optiune == (int)CuloareMasina.Negru)
                Console.WriteLine("{0}\n{1}", culoare[3], buf1);

            if (optiune == (int)CuloareMasina.Gri)
                Console.WriteLine("{0}\n{1}", culoare[3], buf2);

            //Folosirea Enumerari Optiuni Masina
            Console.WriteLine("Alegeti optiunea pe care o doresti :");
            string[] _optiune = { "Aer Conditionat", "Navigatie", "Cutie Automata", "Masini gasite:" };
            Console.WriteLine("[1]{0}\n[2]{1}\n[3]{2}\n", _optiune[0], _optiune[1], _optiune[2]);
            Console.Write("Alege:");
            int alegere = int.Parse(Console.ReadLine());

            if (alegere == (int)OptiuniMasina.AerConditionat)
                Console.WriteLine("{0}\n{1}\n{2}", _optiune[3], buf2,buf1);

            if (alegere == (int)OptiuniMasina.Navigatie)
                Console.WriteLine("{0}\n{1}\n{2}", _optiune[3], buf1,buf2);

            if (alegere == (int)OptiuniMasina.CutieAutomata)
                Console.WriteLine("{0}\n{1}", _optiune[3], buf3,buf10);

            //Implementarea optiuni de a cauta si modifica o masina
            int j = 0;
            Masina[] masinaModificare = new Masina[3 + nrMasini];
            masinaModificare[0] = masina1;
            masinaModificare[1] = masina2;
            masinaModificare[2] = masina3;
            for (int i = 3; i < nrMasini + 3; i++)
            {
                masinaModificare[i] = masina4[j];
                j++;
            }
            Console.WriteLine("Ce masina doriti sa modificati ?");
            for (int i = 0; i < nrMasini + 3; i++)
                Console.WriteLine("[{0}] {1}: {2}", i, masinaModificare[i].NumeVanzator, masinaModificare[i].Tip);

            Console.WriteLine("Optiune:");
            int opt = int.Parse(Console.ReadLine());
            Console.WriteLine("Ce doriti sa modificati la acesta masina ?");
            Console.WriteLine("[0]Tip:{0}\n [1]Nume vazator:{1}\n [2]Nume Cumparator{2} \n [3]Pret:{3} \n [4]An Fabricatie:{4} \n [5]Optiuni:{5} \n [6]Culoare:{6} \n [7]Data Tranzactie:{7} \n", masinaModificare[opt].Tip, masinaModificare[opt].NumeVanzator, masinaModificare[opt].NumeCumparator, masinaModificare[opt].Pret, masinaModificare[opt].AnFabricatie, masinaModificare[opt].Optiuni, masinaModificare[opt].Culoare, masinaModificare[opt].DataTranzactie);
            int Optiune = int.Parse(Console.ReadLine());

            switch (Optiune)
            {
                case 0:
                    masinaModificare[opt].Tip = Console.ReadLine();
                    break;
                case 1:
                    masinaModificare[opt].NumeVanzator = Console.ReadLine();
                    break;
                case 2:
                    masinaModificare[opt].NumeCumparator = Console.ReadLine();
                    break;
                case 3:
                    masinaModificare[opt].Pret = float.Parse(Console.ReadLine());
                    break;
                case 4:
                    masinaModificare[opt].AnFabricatie = int.Parse(Console.ReadLine());
                    break;
                case 5:
                    masinaModificare[opt].Optiuni = Console.ReadLine();
                    break;
                case 6:
                    masinaModificare[opt].Culoare = Console.ReadLine();
                    break;
                case 7:
                    masinaModificare[opt].DataTranzactie = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Nu exista optiunea!");
                    break;
            }
            Console.WriteLine(masinaModificare[opt].Afisare());

            for (int i = 0; i < nrMasini + 3; i++)
            {
                ScriereFisier(masinaModificare[i]);
            }
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
        public static void ScriereFisier(Masina masinaScriereFisier)
        {
            try
            {
                using (StreamWriter dateScrise = new StreamWriter("C://Users//viper//Documents//GitHub//PIU//Proiect//DateOut.txt", true))
                {
                    dateScrise.WriteLine(masinaScriereFisier.ConversieLaSir());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului");
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica!");
            }
        }
        public static Masina[] CitireFisier(out int nrMasini)
        {
            int increment = 1;
            Masina[] date = new Masina[increment];
            nrMasini = 0;
            try
            {
                using (StreamReader DateCitite = new StreamReader("C://Users//viper//Documents//GitHub//PIU//Proiect//DateIn.txt", true))
                {
                    string linie;
                    int i = 0;
                    while ((linie = DateCitite.ReadLine()) != null)
                    {
                        date[i++] = new Masina(linie);
                        if (i == increment)
                        {
                            Array.Resize(ref date, i + increment);
                        }
                    }
                    nrMasini = i;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului");
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica!");
            }
            return date;
        }

    }
}
