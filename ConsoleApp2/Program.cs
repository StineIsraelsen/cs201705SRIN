using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module05Methods
{
    class Program
    {

        //static void Main(string[] args)
        //{
        //    int t = 0;
        //    Test(6, t);

        //    Test2();


        //    Console.WriteLine(Test3(6).v1);
        //}
        //static void Test (int a, int b)
        //{

        //}

        //static void Test2()
        //    {
        //    }

        //static minReturværdi Test3(int y)
        //{
        //    minReturværdi m;


        //        m.v1 = y * 2;
        //        m.v2 = y;
        //        return m;

        //}
        //struct minReturværdi
        //{
        //    public int v1;
        //    public int v2;
        //}

        //Små metoder
        static int LægSammen(int a, int b)
        {
            return a + b;

        }

        static double BeregnAreal(int radius)
        {
            double areal;
            areal = 3.14 * radius * radius;
            return areal;
        }

        static void Udskriv(string txt)
        {
            Console.WriteLine(txt);
        }

        static void Udskriv()
        {
            Console.WriteLine();
        }


        static double BeregnMoms(double beløb, double MomsPct=0.25)
        {
            return beløb * MomsPct;
        }

        static double Gennemsnit(params int[] månedsløn)
        {
            int total = 0;
            int a = 0;

            foreach (int i in månedsløn)
            {
                total += i;
                a++;
            }
            double gns = total / a;

            return gns;
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(LægSammen(2, 4));
        //    Console.WriteLine(BeregnAreal(2));
        //    Udskriv();
        //    Udskriv("Dette er en test");
        //    Console.WriteLine(BeregnMoms(100.35));
        //    Console.WriteLine(BeregnMoms(100.35,0.25));
        //    int[] løn = { 10000, 5000, 30000};
        //    double gns = Gennemsnit(løn);
        //    Console.WriteLine(gns);
        //    Console.ReadLine();


        //}

        // Overload
        static int Beregn(int a, int b)
        {
            return a + b;
        }


        static int Beregn(int a, int b, int c)
        {
            return Beregn(a, b) + c;
        }

        static int Beregn(int a, int b, int c, int d)
        {
            return Beregn(a,b,c) + d;
        }



        //static void Main(string[] args)
        //{
        //    Console.WriteLine(  Beregn(1,2));
        //    Console.WriteLine(Beregn(1, 2, 3));
        //    Console.WriteLine(Beregn(1, 2,4, 5));
        //    Console.ReadLine();
        //}

        
        // Beregn Array
        struct ArrayResultat
        {
            public double sum;
            public double gennemsnit;

        }

        static ArrayResultat BeregnOgSorterArray(int[] array)
        {
            ArrayResultat m;
            m.sum = 0;
    

            foreach (int i in array)
            {
                m.sum += i;
             
            }
            m.gennemsnit = m.sum / array.Length;

            Array.Sort(array);
            return m;
        }

        //static void Main(string[] args)
        //{
        //    int[] test = { 10, 7, 6, 3, 1, 50, 3 };
        //    var res = BeregnOgSorterArray(test);

        //}

        // Ny gennemgang på tavlen: rekursion: Metodekald der hele tiden kalder sig selv.

        //static void f1() {
        //    f2();
        //}

        //static void f2()
        //{
        //    f3();
        //}

        //static void f3()
        //{
        //    Console.WriteLine("i f3");
        //    f1();
        //}

        //static void SkrivFiler(string sti) {
        //    string[] filer =System.IO.Directory.GetFiles(sti);

        //    foreach (var fil in filer)
        //    {
        //        Console.WriteLine(fil);
        //    }
        //    string[] mapper = System.IO.Directory.GetDirectories(sti);
        //    foreach (var mappe in mapper)
        //    {
        //        SkrivFiler(mappe);
        //    }
        //}


        //static void Main(string[] args)
        //{
        //    SkrivFiler("c:\\temp");
        //    Console.ReadLine();
        //}



        // Ny gennemgang på tavlen: rekursion: Metodekald der hele tiden kalder sig selv.

        //static void f1()
        //{
        //    f2();
        //}

        //static void f2()
        //{
        //    f3();
        //}

        //static void f3()
        //{
        //    Console.WriteLine("i f3");
        //    f1();
        //}

        //static void SkrivFiler(string sti)
        //{
        //    string[] filer = System.IO.Directory.GetFiles(sti);

        //    foreach (var fil in filer)
        //    {
        //        Console.WriteLine(fil);
        //    }
        //    string[] mapper = System.IO.Directory.GetDirectories(sti);
        //    foreach (var mappe in mapper)
        //    {
        //        SkrivFiler(mappe);
        //    }
        //}


        //static void Main(string[] args)
        //{
        //    SkrivFiler("c:\\temp");
        //    Console.ReadLine();
        //}
        // rekursion
        static void Main(string[] args)
        {

            LøkkeSomMetode(1, 10);
            Console.ReadLine();
        }

        static void LøkkeSomMetode(int start, int stop)
        {
            Console.WriteLine(start);

            if (start == stop)
                return;

            start++;

            LøkkeSomMetode(start, stop);





        }

        
    }
}
