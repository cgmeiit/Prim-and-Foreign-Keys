using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_for_loop2_even
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a even number");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("How High Should I Count");
            int countlimit = int.Parse(Console.ReadLine());
            int sum = 0;

            if(firstnumber % 2 == 0)
            {
                for (int i = firstnumber; i <= countlimit; i += 2)

                {
                    if (i % 6 == 0)
                    {
                        continue;

                    }
                    sum += i;

                }

                Console.WriteLine("sum =" + sum);
                }

            
                else
            {
                Console.Write("Do better");
                }
            }
        }
    }



