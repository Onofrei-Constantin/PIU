using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Masina
    {
        string marca;
        string model;
        string culoare;
        double pret;
        int anFabricare;

        public Masina()
        {
            marca = string.Empty;
            culoare = string.Empty;
            model = string.Empty;
            pret = 0;
            anFabricare = 0;
        }
        public Masina(string _marca, string _model, string _culoare, double _pret, int _anFabricare)
        {
            marca = _marca;
            model = _model;
            culoare = _culoare;
            pret = _pret;
            anFabricare = _anFabricare;
        }
        public string Info()
        {
            return string.Format("Masina este {0}, modelul {1}, are culoarea {2}, pretul de {3} euro, din anul {4}.",marca,model,culoare,pret,anFabricare);
        }
    }
}

