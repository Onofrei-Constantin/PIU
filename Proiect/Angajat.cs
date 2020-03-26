using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Angajat
    {
       
        public string Email { get; set; }
        public string Parola { get; set; }
        public static int PrezentAngajat { get; set; }

        public Angajat(string _Email, string _Parola)
        {
            Email = _Email;
            Parola = _Parola;
            PrezentAngajat++;
        }
        public class NumeAngajat
        {
            public string Nume { get; set; }
            public string Prenume { get; set; }
            public string NumeComplte
            {
                get
                {
                    return Nume + " " + Prenume;
                }
            }
            public NumeAngajat(string _Nume, string _Prenume)
            {
                Nume = _Nume;
                Prenume = _Prenume;
                PrezentAngajat++;
            }
            
        }
    }  
}
