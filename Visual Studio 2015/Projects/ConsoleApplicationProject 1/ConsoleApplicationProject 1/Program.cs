using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationProject_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string playAgain = "N";

            Console.WriteLine("Fortune Teller App\n");
            Console.WriteLine("Let me see into your future. \nEnter information below to help me predict your future. \n\nYou can Quit at anytime by entering \"Quit\". \nYou can restart at anytime by entering \"Restart\".\n");

            do
            {
                Console.WriteLine("\nEnter Your First Name: ");
                string firstName = Console.ReadLine();
                string firstNameLower = firstName.ToLower();


                Console.WriteLine("Enter Your Last Name: ");
                string lastName = Console.ReadLine();
                string lastNameLower = lastName.ToLower();
                string fullName = firstNameLower + lastNameLower;



                Console.WriteLine("Enter Your Age: ");
                int userAge = int.Parse(Console.ReadLine());
                //age if else conditional
                string retireYears;
                if (userAge % 2 == 0)
                {
                    retireYears = 10.ToString();
                }
                else
                {
                    retireYears = 25.ToString();
                }



                Console.WriteLine("Enter Your Birth Month: ");
                string birthMonth = Console.ReadLine().ToLower();
                double bankRoll = 0;
                for (int i = 0; i < fullName.Length; i++)
                {
                    if (birthMonth[0] == fullName[i])
                    {
                        bankRoll = 1000000.00;
                        break;
                    }
                    else if (birthMonth[1] == fullName[i])
                    {
                        bankRoll = 2000000.00;
                        break;
                    }
                    else if (birthMonth[2] == fullName[i])
                    {
                        bankRoll = 3000000.00;
                        break;
                    }
                    else
                    {
                        bankRoll = 500000.00;
                    }
                }



                Console.WriteLine("Enter Your Favorite ROYGBIV Color (If you do not know ROYGBIV, enter \"Help\" to show a list of ROYGBIV colors):");
                string color = Console.ReadLine().ToLower();
                //ROYGBIV Switch Case conditional
                string transportation = "";

                if (color == "help")
                {
                    Console.WriteLine("ROYGBIV COLORS: \nR is for Red. \nO is for Orange. \nY is for Yellow. \nG is for Green. \nB is for Blue. \nI is for Indigo. \nV is for Violet. \nEnter a ROYGBIV color: ");
                    color = Console.ReadLine();
                }
                switch (color)
                {
                    case "red":
                        transportation = "an electric car";
                        break;
                    case "orange":
                        transportation = "a bike";
                        break;
                    case "yellow":
                        transportation = "a SUV";
                        break;
                    case "green":
                        transportation = "a Toyota Prius";
                        break;
                    case "blue":
                        transportation = "a scooter";
                        break;
                    case "indigo":
                        transportation = "a private jet";
                        break;
                    case "violet":
                        transportation = "a yacht";
                        break;
                }




                Console.WriteLine("Enter the # of Siblings You Have: ");
                int sibNum = int.Parse(Console.ReadLine());
                // sibling sequenced if else conditional
                string sibFortune = "";
                if (sibNum == 0)
                {
                    sibFortune = "Toyko";
                }
                else if (sibNum == 1)
                {
                    sibFortune = "Washington DC";
                }
                else if (sibNum == 2)
                {
                    sibFortune = "Tanzania";
                }
                else if (sibNum == 3)
                {
                    sibFortune = "New York City";
                }
                else if (sibNum > 3)
                {
                    sibFortune = "South Beach Miami";
                }
                else
                {
                    sibFortune = "your ex's basement";
                }



                Console.WriteLine("\n\n{0} {1} will retire in {2} years with ${3} in the bank, a vacation home in {4} and {5}.", firstName, lastName, retireYears, bankRoll, sibFortune, transportation);
                Console.WriteLine("\nWould you like to play again? (Y or N): ");

                playAgain = Console.ReadLine().ToUpper();
            } while (playAgain == "Y");


        }
    }
    }


