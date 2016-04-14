using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine().ToLower();
            //char[] firstNameArray = firstName.ToCharArray();
            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine().ToLower();
            //char[] lastNameArray = lastName.ToCharArray();
            string fullName = firstName + lastName;
            //char[] fullNameArray = fullName.ToCharArray();
            Console.WriteLine("Please enter your birth month: ");
            string birthMonth = Console.ReadLine().ToLower();
            //char[] monthArray = birthMonth.ToCharArray();
            int bankRoll = 0;
            for (int i = 0; i < fullName.Length; i++)
            {
                if (birthMonth[0] == fullName[i])
                {
                    bankRoll = 10000000;
                    break;
                }
                else if (birthMonth[1] == fullName[i])
                {
                    bankRoll = 20000000;
                    break;
                }
                else if (birthMonth[2] == fullName[i])
                {
                    bankRoll = 300000000;
                    break;
                }
                else
                {
                    bankRoll = 500000;
                    break;
                }
            }
            Console.WriteLine("You will retire with " + bankRoll);
           
            }
            
        }
    }

