using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class Car
    {

        public String petname;
        public int currentSpeed;

        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} km/h", petname, currentSpeed);
        }

        public void SpeedUp(int delta)
        {
            currentSpeed += delta;
        }

        // Default constructor

        public Car()
        {
            petname = "Chuck";
            currentSpeed = 10;
        }

        //Custom constructor: Can create more than one. One can also link them to minimize the code to be written.
        public Car(string pt)
        {
            petname = pt;
        }

        public Car(string pn, int cs)
        {
            petname = pn;
            currentSpeed = cs;
        }
    }
}
