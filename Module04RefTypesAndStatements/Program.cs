﻿using System;
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

            // Strings

            //string navn;
            //navn = null;
            //navn = "Mikkel";
            //navn = navn.ToLower(); // der findes en mange metoder, der kan tilgås for strings, direkte efter referencen
            //string nytNavn = navn.ToUpper();
            //string aa = navn.PadLeft(10, '*');


            //string fnavn = "Mikkel";
            //string enavn = " Mæøller";
            //string full = fnavn + " " + enavn;

            //string full2 = $"{fnavn} {enavn} .... {enavn}";

            ////Console.WriteLine("Strart");

            //// bool er udfyld

            //bool? udfyld = true; // ? er det der gør den nullable
            //if (udfyld.HasValue)

            //{
            //    Console.WriteLine(udfyld.Value);
            //}
            //else
            //{
            //    Console.WriteLine("Ikke udfyldt");
            //}


            // Arbejde med strenge

            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string samletNavn = fornavn + " " + efternavn;
            string stortNavn = samletNavn.ToUpper();
            string lilleNavn = stortNavn.ToLower();
            string del = samletNavn.Substring(7, 4);
            string[] navnArray = samletNavn.Split(' ');
            foreach (string i in navnArray)
            {
                Console.WriteLine(i);
            }

            // 10 tabel

            //int[] tal;
            //tal = new int[10];

            for (int i = 1; i < 11; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    string tal = (i * (j+1)).ToString();
                    if ((i*(j+1))>50)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    } 
                       
                    Console.Write(tal.PadLeft(4, ' '));
                }
                Console.WriteLine();
            }






            Console.ReadLine();

        }
    }
}
