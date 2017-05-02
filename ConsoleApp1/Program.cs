using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt;  //Time
            TimeSpan ts; //Difference in time, timespan
            dt = DateTime.Now;
            DateTime Christmas = new DateTime(2017, 12, 24);
            ts = Christmas.Subtract(dt);
            Console.WriteLine(ts.TotalDays);
            Console.ReadLine();

        }
    }
}
