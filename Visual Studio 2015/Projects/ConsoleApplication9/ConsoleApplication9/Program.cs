using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int number2 = int.Parse(Console.ReadLine());

            int sum = add(number1, number2);
            Console.WriteLine(sum);

            
        }
        static int add(int number1, int number2);
        {
         int sum = number1 + number2;
         return sum;

        }

    }





