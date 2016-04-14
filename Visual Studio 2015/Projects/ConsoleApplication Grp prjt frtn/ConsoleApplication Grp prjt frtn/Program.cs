using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Grp_prjt_frtn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fortune Teller App\n");

            Console.WriteLine("Let me see inot your future. \nEnter information below to help me predict your future. \n\nYou can Quit at anytime by entering \"Quit\". \nYou can restart at anytime by entering\"restart\". \n\n");

            Console.Write("Enter Your First Name: ");
            string userNameFirst = Console.ReadLine();
           
            Console.Write("Enter Your Last Name: ");
            string userNameLast = Console.ReadLine();

            Console.Write("Enter Your Age: ");
            int userAge = int.Parse(Console.ReadLine());
            string retireYears;

            //if else conditional
 
            if (userAge % 2 == 0)
            {
                retireYears = 10.ToString();
            }

            else
            {
                retireYears = 25.ToString();
            }


            Console.Write("Enter Your Birth Month: ");
            string userMonth = Console.ReadLine().ToLower();

            Console.WriteLine("Enter Your Favorite ROYGBIV Color (If you do not know ROYGBIV, enter \"Help\" to show a list of ROYGBIV colors):");
            string color = Console.ReadLine().ToLower();
            string transportation = "";

            //ROYGBIV Switch Case conditional
            switch (color)
            {
                case "red":
                   transportation = "Electric Car";
                    break;
                case "orange":
                   transportation = "Bike";
                    break;
                case "yellow":
                   transportation = "SUV";
                    break;
                case "green":
                   transportation = "Hybryd";
                    break;
                case "blue":
                   transportation = "Scooter";
                    break;
                case "indigo":
                   transportation = "Private Jet";
                    break;
                case "violet":
                   transportation = "Yacht";
                    break;
                case "help":
                    Console.Write("ROYGBIV COLORS: \nR is for Red. \nO is for Orange. \nY is for Yellow. \nG is for Green. \nB is for Blue. \nI is for Indigo. \nV is for Violet. \nEnter a ROYGBIV color: ");
                    color = Console.ReadLine().ToLower();
                    break;
            }

            Console.Write("Enter the # of Siblings You Have: ");
            int sibNum = int.Parse(Console.ReadLine());
            string sibFortune="";
            string Bankroll= "";

            // sibling sequenced if else conditional

            if (sibNum == 0)
            {
                sibFortune = "Apartment in Toyko";
            }
            else if (sibNum == 1)
            {
                sibFortune = "Townhouse in Washington DC";
            }
            else if (sibNum == 2)
            {
                sibFortune = "Over Water Bungalow in Tanzania";
            }
            else if (sibNum == 3)
            {
                sibFortune = "Cardboard box in New York City";
            }
            else if (sibNum > 3)
            {
                sibFortune = "Mansion in South Beach Miami";
            }

           


            Console.WriteLine("{0} {1} will retire in {2} years with {3} in the bank, a vacation home in {4} and a {5}.", userNameFirst, userNameLast, retireYears, sibFortune, Bankroll);

            
             







            }
        }
    }





    
        
        


