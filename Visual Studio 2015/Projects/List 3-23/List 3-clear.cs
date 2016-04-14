using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace List_3_23
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Eric", "Daniel", "Chino", "Arianna", "judea" };

            names.Add("Niki");
            names.Add("jack");
            names.Add("Hen");
            names.Add("Sara");
            names.Add("Mel");

            StringBuilder sn = new StringBuilder();

            foreach (string name in names) 


            {
                sn.Append(name);
                sn.Append("\r\n");

            }
            
            //string nmfile = "StudentNM.txt";
            //StreamWriter writer = new StreamWriter(nmfile);
            //using(writer)
            //{
            //    writer.WriteLine(sn);

            //}
            Console.WriteLine(names.Count);
            









                }
            }
        }





