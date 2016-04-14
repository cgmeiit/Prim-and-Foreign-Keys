using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_foreach_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] foods ={" chile ","fish", "vegetable"};

            foreach (string food in foods)
            {
                Console.Write("I love" + foods);

            }




        }
    }
}