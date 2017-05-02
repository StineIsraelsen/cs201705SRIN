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
            Console.WriteLine("indtast navn");
            string name = Console.ReadLine();
            Console.WriteLine("velkommen" + name.toupper());
            Console.Writeline("tryk en tast for at forsætte");
            Console.ReadKey();
        }
    }
}
