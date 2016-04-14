using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_code_eval
{
    class Program
    {
        static void Main(string[] args)
        //{
        //    string line = "some line with text";
        //    string[] words = line.Split()
        //    Console.WriteLine(words[words.Length - 2]);

        //}
        {
           string line = "A collection of words";
           string[] words = line.Split();
           string longest = "";

           foreach (string word in words)

            {
                if (word.Length > longest.Length)
                    longest = word;
            }
            Console.WriteLine(longest);
            Console.WriteLine(longest.Length);


        } 
    }
}
