using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            int avrscores = 0;
            int result = 0;
            List<int> testscores = new List<int> { 50, 55, 60, 65, 70, 75, 80, 90, 95, 100 };
            // StringBuilder score = new StringBuilder();
            foreach (int students in testscores)
            {

                result += students;

            }
            Console.WriteLine(result);
            avrscores = result / testscores.Count;
            Console.WriteLine(avrscores);

            string student = "StudentAS.txt";
            StreamWriter avr = new StreamWriter(student);
            using (avr)
            {
                avr.WriteLine(result);
                avr.WriteLine(avrscores);
            }
            {

                StreamReader reader = new StreamReader(student);
                using (reader)
                {
                    Console.WriteLine(reader);
                }


            }
        }
    }
}
