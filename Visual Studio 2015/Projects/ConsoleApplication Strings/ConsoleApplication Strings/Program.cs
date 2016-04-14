using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Please Enter Name");
            
           string name = Console.ReadLine();
                
           int Length=name.Length;

            for(int counter=0;counter < name.Length;counter++)
            {
                Console.WriteLine(name[counter]);
            }



        }
    }
}
