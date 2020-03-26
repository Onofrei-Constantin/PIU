using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Client
    {
        public string nume { get; set; }
        public string prenume { get; set; }
        public string CNP { get; set; }
        public int perioada { get; set; }
        public double sumaDisponibila { get; set; }
        public static int interesat { get; set; }
        public Client(string _nume, string _prenume, string _CNP, double _sumaDisponibila, int _perioada)
        {
            nume = _nume;
            prenume = _prenume;
            CNP = _CNP;
            sumaDisponibila = _sumaDisponibila;
            perioada = _perioada;
            interesat++;
        }
        public string Info()
        {
            return string.Format("Clientul este: NUME: {0}, PRENUME: {1}, CNP: {2}, SUMA DISPONIBILA: {3} lei, Perioada: {4} zi/zile.", nume, prenume, CNP, sumaDisponibila, perioada);
        }
    }
}