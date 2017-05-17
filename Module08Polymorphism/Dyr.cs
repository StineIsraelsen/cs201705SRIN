using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Polymorphism
{
    class Dyr
    {
        public string Navn { get; set; }

        public virtual void SigNoget() {
            Console.WriteLine("Jeg er et dyr og jeg hedder"+Navn);
        }

        static Random rnd = new Random();

        public static Dyr TilfældigtDyr()
        {
            string sti = @"X:\Michell\Filer\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);
            int index = rnd.Next(0,navne.Length);

            if (index%2==0)
            { return new Hund(){Navn=navne[index] }; }
            else
            { return new Kat(){Navn = navne[index]}; }
        }

    }
}
