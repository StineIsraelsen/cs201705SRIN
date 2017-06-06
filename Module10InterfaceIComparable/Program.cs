using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10InterfaceIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[2];
            hunde[0] = new Hund() {Alder=10, Navn="Bulder"};
            hunde[1] = new Hund() { Alder = 5, Navn = "Lady" };

            Array.Sort(hunde);
            foreach (Hund item in hunde)
            {
                Console.WriteLine(item.Navn);
            }
        }
    }
}
