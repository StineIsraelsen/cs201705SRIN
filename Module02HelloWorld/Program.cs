using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module02HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast navn");
            string name=Console.ReadLine();
            Console.WriteLine("Velkommen {0}", name.ToUpper());
            Console.WriteLine("Tryk en tast for at forsætte");
            Console.ReadKey();
        }
    }
}
