using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a large number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a small number");
            int m = int.Parse(Console.ReadLine());
            decimal factorial = 1;


            while (true)
            {
                if (n <= m - 1)
               
            {
                break;
            }
            factorial *= n;
            n--;
            Console.Write("n!=" + factorial);
        }
        }
    }
}

