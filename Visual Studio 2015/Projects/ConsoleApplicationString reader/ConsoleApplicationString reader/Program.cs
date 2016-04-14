using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApplicationString_reader
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\ConsoleApplication14\ConsoleApplication14\bin\Debug\Squirrel.txt";

            try
            {
                StreamReader reader = new StreamReader(fileName);
                Console.WriteLine("File {0} successfully opened.", fileName);
                Console.WriteLine("File contents:");
                using (reader)
                {
                    Console.WriteLine(reader.ReadToEnd());
                } 
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine(
                    "Can not find file {0}.", fileName);
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine(
                    "Invalid directory in the file path.");
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Cannot open the file {0}", fileName);
            }
        }

    }
}


