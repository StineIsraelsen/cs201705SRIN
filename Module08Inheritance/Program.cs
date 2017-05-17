using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person() { Fornavn="Stine", Efternavn="Israelsen"};
            
            Console.WriteLine(p1.FuldtNavn());
        }
    }
}
