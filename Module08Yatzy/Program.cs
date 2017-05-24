using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Yatzy
{
    class Program
    {
        static void Main(string[] args)
        {
             YatzyBæger b = new YatzyBæger();

            //Terning b = new Terning();

            b.Skriv();
            b.Ryst();
            b.Skriv();

            Console.ReadLine();
        }
    }
}
