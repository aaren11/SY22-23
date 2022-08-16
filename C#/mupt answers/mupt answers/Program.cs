using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mupt_answers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer1;
            string answer2;
            string answer3;
            int correct=0;
            Console.WriteLine("How Many moons does earth have");
            Console.WriteLine("a,1");
            Console.WriteLine("b,2");
            Console.WriteLine("c,3");
            answer1 =(Console.ReadLine());
            Console.WriteLine("what is 15+2");
            Console.WriteLine("a,17");
            Console.WriteLine("b,24");
            Console.WriteLine("c,353");
            answer2 =(Console.ReadLine());
            Console.WriteLine("what is the color ");
            Console.WriteLine("A,15");
            Console.WriteLine("b,Red");
            Console.WriteLine("c,dog");
            answer3 =(Console.ReadLine());
            if (answer1 == "a") { correct++; }
            if (answer2 == "a") { correct++; }
            if (answer3 == "b") { correct++; }
            Console.WriteLine(correct);
            Console.ReadLine();
            Console.WriteLine("Your Score is {0},", correct);
            Console.ReadKey();
           

        }
    } }
