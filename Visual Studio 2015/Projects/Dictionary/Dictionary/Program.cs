using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Dictionary<string, int> theaterCoat = new Dictionary<string, int>();
            //    theaterCoat.Add("cottonCoat", 1);
            //    theaterCoat.Add("peaCoat", 2);
            //    theaterCoat.Add("furCoat", 3);
            //    theaterCoat.Add("bomberCoat", 4);
            //    theaterCoat.Add("trekJacket", 5);
            //    theaterCoat.Add("topCoat", 6);
            //    theaterCoat.Add("skiCoat", 7);
            //    theaterCoat.Add("capeCoat", 8);
            //    theaterCoat.Add("rainCoat", 9);
            //    theaterCoat.Add("horseCoat", 10);


            //    foreach (KeyValuePair<string, int> coats in theaterCoat)
            //    {
            //        Console.WriteLine(coats);

            //    }

            Dictionary<string, int> zooAnimals = new Dictionary<string, int>();
            zooAnimals.Add("Snowmonkey", 5);
            zooAnimals.Add("Lions", 10);
            zooAnimals.Add("Zebras", 20);
            zooAnimals.Add("flyingsquirrels", 1);
            zooAnimals.Add("bats", 30);
            zooAnimals.Add("eagles", 2);
            zooAnimals.Add("polarBears", 4);
            zooAnimals.Add("turtles", 8);
            zooAnimals.Add("hippos", 4);
            zooAnimals.Add("flamingos", 85);

            var highest = 0;


            foreach (var  animal in zooAnimals)

                if (animal.Value > highest)
                   
            {

                    highest = animal.Value;

            }
          foreach (var find in zooAnimals)

                if (highest == find.Value)
                {
                    Console.WriteLine(find.Key);
                }

            


        }
    }
}



    






