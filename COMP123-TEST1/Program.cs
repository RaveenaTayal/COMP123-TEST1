using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_TEST1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating an object for Car class
            Car myCar = new Car("Ford","Ultimate","2011","Grey");

            //Calling drive() method
            myCar.drive();

            //To show the output on Console without crashing
            Console.WriteLine(" Press any key to exit...");
            Console.ReadKey();
        }
    }
}
