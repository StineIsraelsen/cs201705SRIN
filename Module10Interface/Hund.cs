﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10Interface
{
    class Hund:IDbFunktioner
    {

        public string Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer hund...");
        }
    }
}
