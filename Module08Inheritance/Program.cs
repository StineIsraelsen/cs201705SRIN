using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person() { Fornavn="Stine", Efternavn="Israelsen"};
            Elev e1 = new Elev() { Fornavn = "Peter", Efternavn = "Muller", KlasseLokale="Lokale 14"};
            Instruktør i1 = new Instruktør() { Fornavn="Niels", Efternavn="Larsen",NøgleId=3};

            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(e1.FuldtNavn());
            Console.WriteLine(i1.FuldtNavn());
            Console.ReadLine();
        }
    }
}
