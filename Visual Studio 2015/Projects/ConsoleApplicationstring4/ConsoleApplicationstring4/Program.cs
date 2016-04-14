using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationstring4
   
{
    static void Main()
    {
        string text = "EM edit";
        string reversed = ReverseText(text);
        Console.WriteLine(reversed);


        {
        }
        static string ReverseText(string text)
        {
            StringBuilder sb = new StringBuilder();
            for(int i= text.Length - 1; i>= 0; i--)
            {
                sb.Append(text[i]);


            }

            return sb.ToString();

                
        }
    }
}
