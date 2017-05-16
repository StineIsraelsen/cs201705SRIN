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
            Terning t;
            t = new Terning();
            t.Test();
            t.værdi = 1;
            t.værdi2 = 1;
            int v = t.værdi;

            Terning t2;
            t2 = new Terning();
            t2.værdi = 3;

            Terning t3;
            t3 = new Terning();
            t3.værdi = 5;

            Console.WriteLine(t.værdi + " " + t2.værdi + " " + t3.værdi);

            Console.ReadLine();

        }
    }
}
