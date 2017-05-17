using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Terning
{
    class LudoTerning:Terning
    {
        public bool ErGlobus() {
            return Værdi == 3;
        }

        public bool ErStjerne() {
            return Værdi == 5;
        }

        public LudoTerning():base ()
        {

        }

        public LudoTerning(int værdi):base(værdi)
        {

        }
    }
}
