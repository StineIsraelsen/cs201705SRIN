﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Polymorphism
{
    class Person
        
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public virtual void Skriv() {
            Console.WriteLine(Fornavn + " " +  Efternavn);
        }
    }
}
