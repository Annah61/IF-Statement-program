using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_Statement_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            // NB ! means not, or negation
            if (isMale)
            {
                Console.WriteLine("you are male");
            }
            else
            {
                Console.WriteLine("you are female");
            }
            bool isTall = true;
            if (isTall && isMale) {
                Console.WriteLine(" You are both male and tall");

            }
            else if (isTall && isMale)
            {
                Console.WriteLine("you are a short man");
            }
            else if(!(isMale && isTall))
            {
                Console.WriteLine("you are neither a man tall");
            }
            else {
                Console.WriteLine("You are a woman");
            }


            Console.Read();
        }
    }
}
