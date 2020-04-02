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
        public float Pret { get; set; }
        public string Tip { get; set; }
        public string NumeVanzator { get; set; }
        public int AnFabricatie { get; set; }
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
            NumeVanzator = _NumeVanzator;
            NumeCumparator = _NumeCumparator;
            Tip = _Tip;
            Culoare = _Culoare;
            Optiuni = _Optiuni;
            DataTranzactie = _DataTranzactie;
            Pret = _Pret;
        }
        //constructor ce primeste un string ca parametru 
        public Masina(string SirInfo)
        {
            string[] info = SirInfo.Split(' ');
            NumeVanzator = info[1];
            NumeCumparator = info[2];
            AnFabricatie = int.Parse(info[0]);
            Tip = info[3];
            Culoare = info[4];
            Optiuni = info[5];
            DataTranzactie = info[6];
            Pret = float.Parse(info[7]);
        }
        public string ConversieLaSir()
        {
            string sir;
            sir = "AN FABRICARE: " + AnFabricatie + " " + "NUME VAZATOR: " + NumeVanzator + " " + "NUME CUMPARATOR: " + NumeCumparator + " " + "MODEL SI TIP: " + Tip + " " + " " + "CULOARE: " + Culoare + " " + "OPTIUNI: " + Optiuni + " " + "DATA TRANZACTIEI: " + DataTranzactie + " " + "PRET:" + Pret + "EURO";
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
            return string.Format("An fabricare: {0}\n Nume vanzator: {1} \n Nume cumparator: {2} \n Tip: {3}  \n Culoare:{4}\n Optiuni:{5}\n Data tranzactie:{6}\n Pret:{7} EURO\n", AnFabricatie, NumeVanzator, NumeCumparator, Tip, Culoare,Optiuni,DataTranzactie,Pret);
        }  
    }
}
