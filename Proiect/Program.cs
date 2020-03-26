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
            var m = new Masina();
            string s = m.Info();
            Console.WriteLine(s);

            Masina m1 = new Masina("Audi", "A4", "negru", 4500, 2007);
            string s1 = m1.Info();
            Console.WriteLine(s1);
            Console.ReadKey();
        }
    }
}
