using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testfortune
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("First Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Birth Month: ");
            string month = Console.ReadLine();

            string fullName = firstName + lastName;
            int bankRoll = 0;

            while 

            for(int i = 0; i < fullName.Length; i++)
            {
                //Console.Write(fullName[i]);
                if(month[0] == fullName[i])
                {
                bankRoll = 10000000;
                    break;
                }
                else if (month[1] == fullName[i])
                {
                bankRoll = 20000;
                    break;
                }
                else if (month[2] == fullName[i])
                {
                    bankRoll = 500000;
                    break;
                }
                else
                {
                    bankRoll = 1000000;
                    break;
                }
            }
            Console.WriteLine(bankRoll);
        }
    }
}
