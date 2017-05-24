using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Yatzy
{
    class Terning
    {
        private int værdi;
        private static System.Random rnd;

        public int Værdi
        {
            get { return værdi; }
            set {
                if (value<1||value>6)
                {
                    value = 1;
                }
                værdi = value; }
        }

        public void Ryst() {
            this.værdi = rnd.Next(1,7);
        }

        public void Skriv()
        {
            Console.WriteLine('[' + Værdi + ']');
        }
    }

}
