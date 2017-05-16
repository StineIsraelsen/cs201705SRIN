using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module93MinKlasse
{
    // Best practice klasse
    // Internal eller public (usynlig - synlig  for projekter)

    internal class MinKlasse01

    {
        // data (felter)

        // Offentlig (nej tak) eller private (ja tak)

        public int felt; // kan tilgås udefra

        private int felt2; // kan tilgås internt (metoder (bl.a.)

        // metoder (standard metoder(funktioner)

        public void Test1() { } // Kan bruges både  esternt og internt

        private void Test2() { }// kan bruges internt

        //constructor (køres ved brug af new)

        // default (genvej: ctor + 2xtab)
           public MinKlasse01()// Ingen argumenter
        {
            // log
            // initalisering

            //styring af sikkerhed

            //

            this.felt = 1;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
