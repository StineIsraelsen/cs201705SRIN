using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] array = new IDbFunktioner[3];
            array[0] = new Hund();
            array[1] = new Ubåd();
            array[2] = new Hund();

            foreach (IDbFunktioner item in array)
            {
                item.Gem();
            }
        }
    }

    
}
