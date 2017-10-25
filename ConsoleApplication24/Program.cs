using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car auto = new Car();

            //Car auto2 = new Car(45.6,"Ford");

            Car auto3 = Car.Create(3.4, "Fiat");
            //Car.iloscKol = 5;
            Car auto4 = Car.Create(4.2, "Opel");
            //Console.WriteLine(auto3.Info());
            //auto3.iloscDrzwi = 4;
            //Console.ReadKey();
            
        }
    }
}
