using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_even_code_eval
{
    class Program
    {
        static void Main(string[] args)
        {

            string line = "fuck";

            int numberEntered = int.Parse(line); 

            int numberTested = (numberEntered % 2);

            if (numberTested == 0)
            {
                Console.WriteLine("1"); //even

            }
            else
            {
                Console.WriteLine("0"); //odd

            }
        }
    }
}
