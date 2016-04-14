using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_sum_digit
{
    class Program
    {
        static void Main(string[] args)
        {

            //string line = "12345";
            //int total = 0;

            //char[] newArray = line.ToCharArray();



            //for (int i = 0; i < newArray.Length; i++)
            //{
            //    string currentNumber = newArray[i].ToString();
            //    total += int.Parse(currentNumber);

            //}

            //Console.WriteLine(total);

            {

                int englishNumber = 0;
                int mathNumber = 0;
                int scienceNumber = 0;
                int socStudiesNumber = 0;
                int musicNumber = 0;
                double total = 0.00d;
                double gpa = 0.00d;


                Console.WriteLine("Enter Student name");
                String studentName =Console.ReadLine();
                
                Console.WriteLine("English Grade ");
                Char englishGrade = char.Parse(Console.ReadLine());
                if (englishGrade == 'A') { englishNumber = 4; }
                if (englishGrade == 'B') { englishNumber = 3; }
                if (englishGrade == 'C') { englishNumber = 2; }
                if (englishGrade == 'F') { englishNumber = 0; }
                Console.WriteLine("Math Grade ");
                Char MathGrade = char.Parse(Console.ReadLine());
                if (MathGrade == 'A') { mathNumber = 4; }
                if (MathGrade == 'B') { mathNumber = 3; }
                if (MathGrade == 'C') { mathNumber = 2; }
                if (MathGrade == 'F') { mathNumber = 0; }
                Console.WriteLine("Science Grade ");
                Char ScienceGrade = char.Parse(Console.ReadLine());
                if (ScienceGrade == 'A') { scienceNumber = 4; }
                if (ScienceGrade == 'B') { scienceNumber = 3; }
                if (ScienceGrade == 'C') { scienceNumber = 4; }
                if (ScienceGrade == 'F') { scienceNumber = 4; }
                Console.WriteLine("Soc Studies Grade ");
                Char socStudiesGrade = char.Parse(Console.ReadLine());
                if (socStudiesGrade == 'A') { socStudiesNumber = 4; }
                if (socStudiesGrade == 'B') { socStudiesNumber = 3; }
                if (socStudiesGrade == 'C') { socStudiesNumber = 2; }
                if (socStudiesGrade == 'F') { socStudiesNumber = 0; }
                Console.WriteLine("Music Grade ");
                Char MusicGrade = char.Parse(Console.ReadLine());
                if (MusicGrade == 'A') { musicNumber = 4; }
                if (MusicGrade == 'B') { musicNumber = 3; }
                if (MusicGrade == 'C') { musicNumber = 2; }
                if (MusicGrade == 'F') { musicNumber = 0; }
                total = englishNumber + mathNumber + scienceNumber + socStudiesNumber + musicNumber;
                gpa = total / 5;

                Console.WriteLine("The GPA for" + studentName + "=" + gpa);




            }
            

            }

    }

}
