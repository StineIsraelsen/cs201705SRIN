using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07Vare
{
    class Vare
    {
        private string navn;

        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }

        private double pris;

        public double Pris
        {
            get { return pris; }
            set { pris = value; }
        }

        //custom constructor


        public Vare(string navn, double pris)
        {
            this.navn = navn;
            this.pris = pris;

        }


        public Vare()
        {
          

        }

        public double PrisMedMoms()
        {
            return pris * 1.25;
        }

    }
}
