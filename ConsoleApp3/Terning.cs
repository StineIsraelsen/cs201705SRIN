using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06OOP
{
    class Terning
    {

        private static System.Random rnd = new Random(); // sørger for at de tilfældige tal er tilfældie.

        
        //data/variabler
        public int værdi; // kan kun læses inden for klassen

        public int værdi2;  // kan læses uden for klassen

        public void Ryst() {
            this.værdi = rnd.Next(1, 7);
        }

        public void Test()
        {
            this.værdi = 1;

        }
    }
}
