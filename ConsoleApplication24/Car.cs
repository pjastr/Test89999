using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Car
    {
        private double pojemnoscSilnika;
        private string marka;

        private Car()
        {
            marka = "Skoda";
        }

        private Car(double pojemonoscSilnika, string marka)
        {
            this.marka = marka;
            this.pojemnoscSilnika = pojemonoscSilnika;

        }

        public static Car Create(double poj, string marka)
        {
            Car temp = new Car(poj, marka);
            return temp;
        }

        public string Info()
        {
            return marka + pojemnoscSilnika;
        }

        public readonly static int iloscKol;

        static Car()
        {
            iloscKol = 4;
        }

        //~Car()
        //{
        //    Console.WriteLine("Zwalniam pamięć");
        //    Console.ReadKey();
        //}

        public const int iloscDrzwi = 4;
    }
}
