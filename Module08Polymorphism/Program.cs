using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dyr[] SamlingAfDyr = new Dyr[20];
            //for (int i = 0; i < SamlingAfDyr.Length; i++)
            //{
            //    SamlingAfDyr[i] = Dyr.TilfældigtDyr(); 
            //}

            //for (int i = 0; i < SamlingAfDyr.Length; i++)
            //{
            //    SamlingAfDyr[i].SigNoget();
            //}
            //Console.ReadLine();

            Person p = new Person() { Efternavn="Israelsen", Fornavn="Stine"};
            Elev e = new Elev() { Efternavn = "Israelsen", Fornavn = "Stine", Klasselokale="Lokale 14" };
            Instruktør i = new Instruktør() { Efternavn = "Israelsen", Fornavn = "Stine", NøgleId=14 };

            Person[] lst = new Person[3];

            lst[0] = p ;
            lst[1] = e ;
            lst[2] = i;

            foreach (var item in lst)
            {
                item.Skriv();
            }

            Console.ReadLine();
        }
    }
}
