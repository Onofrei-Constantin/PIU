using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public class Masina
    {
        public string marca { get; set; }
        public string model { get; set; }
        public string culoare { get; set; }

        public string pret { get; set; }
        public string anFabricare { get; set; }

        public Masina(string masina)
        {
            string[] buff = masina.Split(',');
            marca = buff[0];
            model = buff[1];
            culoare = buff[2];
            pret = buff[3];
            anFabricare = buff[4];
        }
        public void afisare()
        {
            Console.WriteLine("Masina este {0}, modelul {1}, are culoarea {2}, pretul de {3} lei, din anul {4}.",marca,model,culoare,pret,anFabricare);
        }
    }
}

