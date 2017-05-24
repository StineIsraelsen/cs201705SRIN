using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Yatzy
{
    class YatzyBæger:Terning
    {

        private Terning[] terninger;
        public YatzyBæger()
        {
            terninger = new Terning[5];

            for (int i = 0; i < terninger.Length; i++)
            {
                terninger[i] = new Terning();
            }
       
        }

        public void Ryst()
        {
            foreach (var item in this.terninger)
            {
                item.Ryst();
            }
        }

        public void Skriv()
        {
            foreach (var item in this.terninger)
            {
                item.Skriv();
            }
            Console.WriteLine();
        }

        public bool FemEns()
        {
            bool femens = false;

            Terning n = new Terning();
            n=terninger[1];
            for (int i = 0; i < terninger.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < terninger.Length; j++)
                {
                    if (terninger[].Terning == i)
                        count++;
                    if (count>4)
                    {
                        femens = true;
                    }

                }
            }

            return femens;
        }


        public bool TreEns()
        {
            bool treens = false;

            Terning n = new Terning();
            n = terninger[1];
            for (int i = 0; i < terninger.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < terninger.Length; j++)
                {
                    if (terninger[].Terning == i)
                        count++;
                    if (count > 2)
                    {
                        treens = true;
                    }

                }
            }

            return treens;
        }
    }
}
