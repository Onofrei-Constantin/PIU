using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    class Masina
    {
        //proprietati
        public int AnFabricatie { get; set; }
        public float Pret { get; set; }
        public string Tip { get; set; }
        public string NumeVanzator { get; set; }
        public string NumeCumparator { get; set; }
        public string Culoare { get; set; }
        public string Optiuni { get; set; }
        public string DataTranzactie { get; set; }
        //constructor implicit
        public Masina()
        {
            AnFabricatie = 0;
            Pret = 0.0f;
            Tip = NumeCumparator = NumeVanzator = Culoare = Optiuni = DataTranzactie = string.Empty;
        }
        //constructor cu parametri
        public Masina(int _AnFabricatie, float _Pret, string _NumeVanzator, string _NumeCumparator, string _Tip,string _Culoare,string _Optiuni,string _DataTranzactie)
        {
            AnFabricatie = _AnFabricatie;
            Pret = _Pret;
            Tip = _Tip;
            NumeVanzator = _NumeVanzator;
            NumeCumparator = _NumeCumparator;
            Culoare = _Culoare;
            Optiuni = _Optiuni;
            DataTranzactie = _DataTranzactie;
        }
        //constructor ce primeste un string ca parametru 
        public Masina(string SirInfo)
        {
            string[] info = SirInfo.Split(' ');
            AnFabricatie = int.Parse(info[0]);
            Pret = float.Parse(info[1]);
            NumeVanzator = info[2];
            NumeCumparator = info[3];
            Tip = info[4];
            Culoare = info[5];
            Optiuni = info[6];
            DataTranzactie = info[7];
        }
        public string ConversieLaSir()
        {
            string sir;
            sir = "NUME VAZATOR: " + NumeVanzator + " " + "NUME CUMPARATOR: " + NumeCumparator + " " + "MODEL SI TIP: " + Tip + " " + "AN FABRICARE: " + AnFabricatie + " " + "CULOARE: " + Culoare + " " + "OPTIUNI: " + Optiuni + " " + "DATA TRANZACTIEI: " + DataTranzactie + " " + "PRET:" + Pret;
            return sir;
        }
        public bool ComparaDouaMasini(Masina masinaComp)
        {
            bool comp = false;
            if (masinaComp.Tip == Tip && masinaComp.Optiuni == Optiuni && masinaComp.Pret == Pret && masinaComp.Culoare == Culoare && masinaComp.AnFabricatie == AnFabricatie)
                comp = true;
            return comp;
        }
        public string Afisare()
        {
            return string.Format(" Nume vanzator: {0} \n Nume cumparator: {1} \n Tip: {2}  \n An fabricare: {3} \n Culoare:{4}\n Optiuni:{5}\n Data tranzactie:{6}\n Pret:{7} EURO\n", NumeVanzator, NumeCumparator, Tip, AnFabricatie, Culoare,Optiuni,DataTranzactie,Pret);
        }
        
    }
}
