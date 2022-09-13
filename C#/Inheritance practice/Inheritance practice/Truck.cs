using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_practice
{
    internal class Truck: vehicle
    {
        public void stop()
        {
            Console.WriteLine("Truckstop");
        }
        public void drive()
        {
            Console.WriteLine("Truckdrive");
        }
    }
}
