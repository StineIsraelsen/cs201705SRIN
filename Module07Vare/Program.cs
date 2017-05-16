using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07Vare
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Vare v1;
            v1 = new Vare();
            v1.Pris = 1000;
            v1.Navn = "Mad";
            Console.WriteLine(v1.Pris+" " +v1.Navn);
            Console.WriteLine(v1.PrisMedMoms());
            Console.ReadLine();
            
            



    }
    }
}
