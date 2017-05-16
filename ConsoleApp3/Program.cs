using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Terning t1;
            //t = new Terning();
            //t.værdi = 1;
            //t.værdi2 = 1;
            //int v = t.værdi;

            //Terning t2;
            //t2 = new Terning();
            //t2.værdi = 3;

            //Terning t3;
            //t3 = new Terning();
            //t3.værdi = 5;


            // Terning
            //Terning t1;
            //t1 = new Terning();

            //Terning t2;
            //t2 = new Terning(2);

            //Console.WriteLine(t1.Værdi);
            //Console.WriteLine(t2.Værdi);
            //t2 = t1;

            //Console.WriteLine(t1.Værdi);
            //Console.WriteLine(t2.Værdi);

            //t1.Værdi = 5;


            //Console.WriteLine(t1.Værdi);
            //Console.WriteLine(t2.Værdi);

            //t2.Værdi = 3;

            //Console.WriteLine(t1.Værdi);
            //Console.WriteLine(t2.Værdi);


            // terning offentlige og proivate medlemmer

            Terning t1 = new Terning();

            t1.Skriv();
            t1.Ryst();
            t1.Skriv();


            Terning t2 = new Terning(true);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();

            Terning t3 = new Terning(false);
            t3.Skriv();
            t3=t2;
            t3.Skriv();

            Console.ReadLine();

        }
    }
}
