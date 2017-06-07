using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11CollectionGeneric
{
    class Bunke:Kort
    {
        private Stack<Kort> bunke=new Stack<Kort>();

        public void TilFøjKort(Kort k)
        {
            bunke.Push(k);
        }

        public Kort FjernKort()
        {
            if (bunke.Count>0)
            {
                return bunke.Pop();
            }
            return null;
            
        }

        public void Vis()
        {
            foreach (Kort item in bunke)
            {
                Console.WriteLine(item.ToString());
            }
        }

    }
}
