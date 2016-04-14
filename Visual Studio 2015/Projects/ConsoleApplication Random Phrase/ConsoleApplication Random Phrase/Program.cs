using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Random_Phrase
{
    class Program
    {
        static void Main(string[] args)
        {
            //create random phrases
            //get a random # based on the numer of phrases we use 
            //create array 3 phrases
            {

                {
                    string playAgain = "N";
                    string[] responses = { "yes ", "no ", "maybe ", "sometimes ", "always " };
                    var max = responses.Length;//max has the value of 3
                    Random random = new Random();//this gets length of array. 3
                    //max = 3 and the Length and has the value of the array 
                   

                    do
                    {
                        Console.WriteLine("would you like to quite or restart");
                        Console.ReadLine();

                        var selectedNum = random.Next(max);
                        Console.WriteLine(responses[selectedNum]);

                        Console.WriteLine("would you like to Quit or Restart the game (Quit or Restart) ?");
                        playAgain = Console.ReadLine();
                    }
                    while (playAgain == "Restart");


                }

            }
        }
    }
}



                