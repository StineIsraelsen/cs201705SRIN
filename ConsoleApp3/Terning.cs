using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06OOP
{
    class Terning
    {

        //private static System.Random rnd = new Random(); // sørger for at de tilfældige tal er tilfældie.


        public int Værdi;
        private bool snyd;


        private static Random rnd = new Random();

        // default constructor
        public Terning()
        {
            this.Værdi = 1;
            this.snyd = false;

        }


        //custom constructor
        public Terning(bool snyd)
        {
            this.Værdi = 1;
            this.snyd = snyd;

        }

        public void Skriv()
        {
            Console.WriteLine(this.Værdi);
        }


        public void Ryst()
        {
            if (snyd)
                this.Værdi = 6;
            else
                this.Værdi = rnd.Next(1, 7);
        }

    }
}
