using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson 
{ }
    class Program
{
    static void Main(string[] args)
    {
        string line = "2 7 15"; //simulating codeeval input, do not copy and paste
        string[] arrayOfNumbers = line.Split();//splitting string line in to an array of that holds each number(still has a string)
        int fizz = int.Parse(arrayOfNumbers[0]); //fizz number
        int buzz = int.Parse(arrayOfNumbers[1]);//buzz number
        int limit = int.Parse(arrayOfNumbers[2]);//how high to count

        for (int counter = 1; counter <= limit; counter++)

        {

            if (counter % fizz == 0 && counter % buzz == 0)
            {
                Console.WriteLine("FB");
            }
            else if (counter % fizz == 0)
            {
                Console.WriteLine("F");
            }
            else if (counter % buzz == 0)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine(counter);

            }
        }
    }
}




