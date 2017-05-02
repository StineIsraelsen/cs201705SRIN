using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04RefTypesAndStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //int mdr1 = 10;
            //int mdr2 = 3;
            //int mdr3 = 12;
            //int mdr4 = 15;
            //double sum = mdr1 + mdr2 + mdr3 + mdr4;
            //double gns = sum / 4;
            //int[] mdr; // array der hedder mdr, ligger på stacken, laver en ref til et object der ligger på heapen
            //mdr = new int[4]; // 4 elementer, laver et object der ligger på heapen.
            //mdr[0]=10;
            //mdr[1] = 3;
            //mdr[2] = 12;
            //mdr[3] = 15;

            //double sum1 = 0;
            //for (int i = 0; i < mdr.Length; i++)
            //{
            //    sum1 = sum1 + mdr[i];
            //}
            //double gns1 = sum1 / mdr.Length;

            //int[] mdrny = { 10, 3, 12, 15, 2, 100 };

            //System.Array.Sort(mdrny);

            //int[] månedsløn;
            //månedsløn = new int[6];
            int[] månedsløn = {10000, 20000, 15000, 20000, 30000,15000 };

            double sum1 = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum1 = sum1 + månedsløn[i];
            }

            double gns = sum1 / månedsløn.Length;

            for (int i = 0; i < månedsløn.Length; i++)
            {
                Console.WriteLine(månedsløn[i]);
            }
            Console.WriteLine("Gennemsnit " + gns);
            // Presenter de sortede månedslønninger

            
            Array.Sort(månedsløn);

            for (int i = 0; i < månedsløn.Length; i++)
            {
                Console.WriteLine(månedsløn[i]);
            }
            Console.WriteLine("Gennemsnit " + gns);
            Console.ReadLine();

        }
    }
}
