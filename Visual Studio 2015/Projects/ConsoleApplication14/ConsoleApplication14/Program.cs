using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        //{
        //    StreamWriter writer = new StreamWriter("Answers.txt");
        //    using (writer)
        //    {
        //        writer.WriteLine("Hello world");

        //    }
        //}

        //{
        //    string filename = @"somedir\somefile.txt";
        //    try
        //    {
        //        StreamReader reader = new StreamReader(filename);
        //        Console.WriteLine("file {0} sucessfulle opened.", filename);
        //        Console.WriteLine("file contents:");
        //        using (reader)
        //        {
        //            Console.WriteLine(reader.ReadToEnd());
        //        }
        //    }
        //    catch (FileNotFoundException)
        //    {
        //        Console.Error.WriteLine("Can not find file{0}.", filename);

        //    }
        //    catch (DirectoryNotFoundException)
        //    {
        //        Console.Error.WriteLine("Invalid directory inthe file path.");
        //    }
        //    catch (IOException)
        //    {
        //        Console.Error.WriteLine("cannot open the file{0}", filename);


        //    }
        {
            StreamWriter writer = new StreamWriter("Squirrel.txt");

            using (writer)

            {
                writer.WriteLine("Once upon a time there was a squirrel who lived in a tall oak tree\n A woodpecker asked him for the time.\n\"Half past an acorn,\"he replied. ");


            }
            {
                string fileName = @"Squirrel.txt";
                try
                {
                    StreamReader reader = new StreamReader(fileName);
                    Console.WriteLine("File {0} successfully opened.", fileName);
                    Console.WriteLine("File contents:");
                    using (reader)
                    {
                        Console.WriteLine(reader.ReadToEnd());
                    } //this will close the file
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
}
 







