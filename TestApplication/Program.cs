using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method1
            int i = 42;
            Twice(ref i);
            Console.WriteLine(i);

            //Method 2
            int x;
            FillWithNumber(out x);
            Console.WriteLine(x);

            //Method 3
            Console.WriteLine(Sum(42, 87));

            //Method 4
            int[] myArray = { 42, 87, 112, 99,208};
            Increment(myArray);
            Console.WriteLine(myArray[1]);

            //Method 5
            Console.WriteLine(Factorial(10));


            //Class car
            Car myCar = new Car();
            myCar.petname = "Goofy";

            for (int k = 0; k< 5; k++)
            {
                myCar.SpeedUp(10);
                myCar.PrintState();

            }

            Console.ReadLine();
        }

        //Method 1
        static void Twice(ref int i)
        {
            i = 2 * i;
        }

        //Method 2
        static void FillWithNumber(out int x) {
            x = 15;
        }

        //Method 3
        static int Sum(params int[] values) {
            int total = 0;
            foreach (int i in values)
            {
                total += i;
            }
            return total;
        }

        //Method 4
        static void Increment(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i]++;
            }
        }

        //Method 5: recursive methods
        static int Factorial(int n)
        {
            if (n <= 1)
            { return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
