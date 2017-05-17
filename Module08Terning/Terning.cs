using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Terning
{
    class Terning
    {
       
        private int værdi;
        private static System.Random rnd;

        public int Værdi
        {
            get {
                Console.WriteLine("Værdien på terningen aflæses til");
                
                return værdi; }
            set {
                if (value < 1||value>6)
                { value = 1; }
                Console.WriteLine("Terning tildeles værdi...");
                this.værdi = value;
                }
        }

        static Terning()
        {
              rnd = new Random();
        }

        public Terning()
        {
            this.Ryst();
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }
        public void Ryst() {
            this.Værdi = rnd.Next(1,7);
        }

        public void Skriv() {
            Console.WriteLine("[" + Værdi + "]");
        }
    }
}
