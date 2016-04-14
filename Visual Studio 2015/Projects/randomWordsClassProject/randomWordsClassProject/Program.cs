using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace randomWordsClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a streamwriter file


            //create string array //come up random words
            string[] randomize = { "shrinkage", "ice ice baby", "snowman", "frost bite", "shoveling", "igloo", "yeti", "snowcone", "Elsa", "dead body", "leg lamp", "frozen margarita", "alaska", "north pole", "Santa", "bubble coat", "snowboard", "white" };


            Random random = new Random();

            StringBuilder sf = new StringBuilder();



            for (int i = 0; i < 10; i++)
            {
                sf.Append(randomize[random.Next(randomize.Length)]);
                sf.Append(" ");

            }
            StreamWriter coldWords = new StreamWriter("frozen.txt");
            using (coldWords)
            {
                coldWords.WriteLine(sf);
            }
            try
            {

                StreamReader winter = new StreamReader("frozen.txt");
                using (winter)
                {
                    string line;
                    while ((line = winter.ReadLine()) != null)


                    {
                        Console.WriteLine(line);
                    }
                }
           }
           catch (Exception e)
            {
                Console.WriteLine("File can not be read");
                Console.WriteLine(e.Message);


            }
    }
    }
}



