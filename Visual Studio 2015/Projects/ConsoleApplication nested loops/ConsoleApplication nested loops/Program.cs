using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_nested_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("enter number ");

              int num = int.Parse(Console.ReadLine());

              for(int row =1; row<= num; row++)
              {
                  for(int col=1; col<= row; col++)
                  {
                      Console.Write(col + " ");

                  }
                  Console.WriteLine();*/

            {
                for (int hour = 12; hour >= 1; hour--)
                {
                    for (int min = 59; min > 1; min--)

                    {
                        for (int sec = 59; sec > 1; sec--)
                        {
                            Console.WriteLine(hour + ":" + min + ":" + sec);
                            System.Threading.Thread.Sleep(1000);

                        }



                    }


                }
            }
        }
    }
}


