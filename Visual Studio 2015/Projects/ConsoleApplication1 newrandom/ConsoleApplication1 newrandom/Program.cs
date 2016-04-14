using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_newrandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for (int number=1;number<=10; number++)
            {
                int randomNumber = rand.Next(100,201);
                Console.WriteLine("{0}", randomNumber);

            }
        }
    }
}
