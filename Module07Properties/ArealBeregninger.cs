using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07Properties
{
    static class ArealBeregninger
    {

        static public double BeregnArealFirkant(double højde, double bredde) {
            return højde * bredde;
        }

        static public double BeregnArealCirkel(double radius) {
            return Math.Pow(radius,2)*Math.PI;
        }
    }
}
