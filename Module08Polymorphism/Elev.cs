using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Polymorphism
{
    class Elev:Person
    {
        public string Klasselokale { get; set; }

        public override void Skriv()
        {
            Console.WriteLine(Fornavn + " " + Efternavn + ", Klasselokale: " + Klasselokale);
        }
    }
}
