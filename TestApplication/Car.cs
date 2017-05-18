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
            petname="Chuck"
        }
    }
}
