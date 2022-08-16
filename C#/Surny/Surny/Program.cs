using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int awswers;
            Console.WriteLine("enter your age");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine(x);
            Console.ReadLine();
            Console.WriteLine("your age is " + x);
            Console.ReadLine();
            Console.WriteLine("your name is {0}",x);
            Console.ReadLine();
            Console.WriteLine($"Your age is {x}");
            Console.ReadLine();
            Console.WriteLine(@"Your age is {x}");
            Console.ReadLine();
        }
    }
}
