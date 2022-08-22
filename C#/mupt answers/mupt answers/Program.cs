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
            showQuestion("How Many moons does earth have", " a)1", " b)2", " c)0,",
" d)6", "a");

            showQuestion("What is 15+2", " a)1", " b)2", " c)17,", " d)6", "c");

            showQuestion("What is a color ", " a)15", " b)red", " c)dog,", " d)6",
"c");

            showQuestion("What is 1+1", " a)1", " b)2", " c)0,", " d)6", "b");
            Console.ReadKey();
        }
        public static void showQuestion(string question,
                                        string answer1,
                                        string answer2,
                                        string answer3,
                                        string answer4,
                                        string correct)
        {
            Console.WriteLine(question);
            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
            Console.WriteLine(answer4);
            string answer = Console.ReadLine();
            if (answer.Equals(correct))
            {
                Console.WriteLine("you got it right ");
                Console.ReadKey();
            }

        }
    }
}