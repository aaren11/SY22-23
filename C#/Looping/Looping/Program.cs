using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Looping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int lower = 0;
            //int upper = 0;
            //WriteLine("Enter a upper vaule number");
            //upper = int.Parse(ReadLine());
            //WriteLine(upper);
            //WriteLine("Enter a lower vaule number");
            //lower = int.Parse(ReadLine());
            //WriteLine(lower);

            //    WriteLine("\n");

            //    // count up using ++
            ////    for (int i = 1; i <= 100; i++)
            //    {
            //  //      WriteLine(i);
            //    }

            // ReadKey();
            // WriteLine("\n");
            //// count down using --
            //     for (int i = 50; i >= 0; i--)
            // {
            //     WriteLine(i);
            // }

            //ReadKey();
            //WriteLine("\n");
            ////counting by 2
            // for (int i = 100; i <= 200; i+=5)
            //{
            //          WriteLine(i);
            //}

            //ReadKey();

            //WriteLine("\n");
            //// count down using -- by -4
            //for (int i = 20; i >= -20; i--)
            //{
            //    if (i== 12)
            //    {
            //        break ;
            //    }
            //    WriteLine(i);
            //}
            //ReadKey();

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 11; j++)
            //    {
            //        Write(i);
            //    }
            //    WriteLine();
            //}

            //ReadKey();
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Write(i);
            //    }
            //    WriteLine();
            //}

            //ReadKey();

            for (int i = 5; i >= 1; i--)
            {
                for (int j = i - 1; j >= 1 - i; j--)
                {
                    Write(i);
                }
                WriteLine();
            }

            ReadKey();

            ReadKey();
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Write(i);
                }
                WriteLine();
            }

            ReadKey();
        }
    }
}
