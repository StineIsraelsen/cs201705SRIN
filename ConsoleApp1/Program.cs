using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // First part
            int helTal = 10;
            ++helTal;
            --helTal;
            helTal += 20;
            Console.WriteLine(helTal);

            //Second part
            double kommatal = 12.5;
            ++kommatal;
            --kommatal;
            kommatal *= 2;
            Console.WriteLine(kommatal);

            //Third part
            FilTyper ft = FilTyper.csv;
            Console.WriteLine((int) ft);


            //Fourth part
            DateTime dt=DateTime.Now;
            Console.WriteLine(dt.ToLongDateString());

            //Fifth part
            Person p;
            p.Id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn);

            // Console readline to keep prompt
            Console.ReadLine();



        }
        //Third part 
        enum FilTyper
        {csv,
        pdf,
        txt
        }
        //Fifth part
        struct Person
        {
            public int Id;
            public string Navn;
        }
    }
}
