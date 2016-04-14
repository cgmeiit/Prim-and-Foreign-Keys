using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            string ExitRequired;

            while (ExitRequired(line))
            {
                Console.WriteLine("Enter quit to exit...");
                line = string.Parse(Console.ReadLine());

                if (ExitRequired(line))
                    break;
            }
    }
}
