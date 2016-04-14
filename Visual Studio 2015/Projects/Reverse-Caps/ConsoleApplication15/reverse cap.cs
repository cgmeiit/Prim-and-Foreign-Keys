using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main()
        {
            string text = "EM EDIT";
            string reversed = ReverseText(text);
            Console.WriteLine(reversed);
            string caps = ExtractCapitals(text);
            Console.WriteLine(caps);

        }
        public static string ExtractCapitals(string str)
        {
            StringBuilder result = new StringBuilder();
            for(int i =0; i < str.Length; i++)
            {
                Char ch = str[i];
                if (Char.IsUpper(ch))
                {
                    result.Append(ch);
                }

            }
            return result.ToString();
        }

        static string ReverseText(string text)
        {
            StringBuilder SB = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--) 
            {
                SB.Append(text[i]);

            }
            return SB.ToString();

        

        }
    }
}
