using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p1 = new Person() { Fornavn = "Stine", Efternavn = "Israelsen" };
            Terning t1 = new Terning() ;

            LudoTerning l1 = new LudoTerning();
            Console.WriteLine("Terning");
            t1.Skriv();
            Console.WriteLine("LudoTerning");
            l1.Skriv();
            Console.ReadLine();

        }
    }
}
