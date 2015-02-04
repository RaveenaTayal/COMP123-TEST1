using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_TEST1
{
    class Car
    {
        //----------------------------------PRIVATE PROPERTIES--------------------------------------
        private string Make;
        private string Model;
        private string Year;
        private string Colour;

        //----------------------------------CONSTRUCTOR---------------------------------------------
        public Car(string Make,string Model,string Year,string Colour)
        {
            //Initialising instance variables
            this.Make=Make;
            this.Model=Model;
            this.Year=Year;
            this.Colour=Colour;
            this.show();
        }
        //----------------------------------PUBLIC METHODS------------------------------------------
        public void drive()
        {
            Console.WriteLine(" The car is Driving");
            Console.WriteLine();
        }

        public void show()
        {
            Console.WriteLine();
            Console.WriteLine(" Wanna know about your Car?????");
            Console.WriteLine(" Here's it !!!!!");
            Console.WriteLine(" ------------------");
            Console.WriteLine(" Make: {0}", Make);
            Console.WriteLine(" Model: {0}", Model);
            Console.WriteLine(" Year: {0}",Year );
            Console.WriteLine(" Colour: {0}", Colour);
            Console.WriteLine(" ------------------");
            Console.WriteLine();
        }
    }
}
