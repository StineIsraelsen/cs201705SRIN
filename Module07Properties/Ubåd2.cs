using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07Properties
{
    class Ubåd2
    {
        private string nummer;

        public void SætNummer(string nummer) { //set
            //log

            if (nummer == null || nummer == "")
                nummer = "U?";
            this.nummer = nummer;
        }


        public string HentNummer() {//get

            // log
            // sikkerhed må bruger overhovet få nummer
            return this.nummer.ToUpper(); 
        }
        public void Skriv()
        {
            Console.WriteLine("Jeg er ubåd nummer" + this.nummer);
        }

    }
}
