using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07Trekant
{
    public class Trekant
    {
        public int Grundlinje { get; private set;}
        public int Højde { get; private set; }



        //Custom constructor
        public Trekant(int Grundlinje, int Højde)
        {
            this.Grundlinje = Grundlinje;
            this.Højde = Højde;

        }


        //Egenskab
        public double Areal
        {
            get { return 0.5*this.Grundlinje*this. Højde; }

        }

        //Som metode
        //public double Areal() {
        //    return 0.5 * Grundlinje * Højde;
        //}


        // Bedste måde at lave tilfældige tal
        private static System.Random rnd = new Random();//  kun en instans sikrer at værdierne bliver tilfældige.
    }
}
