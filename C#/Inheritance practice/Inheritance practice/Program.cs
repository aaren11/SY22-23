using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            vehicle v = new vehicle();
            Truck t = new Truck();
            t.drive();
            t.stop();
            v.fill();
            Console.ReadKey();
            
        }
    }
}
