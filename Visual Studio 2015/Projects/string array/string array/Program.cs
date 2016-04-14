using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ToyTypes = { "dolls", "cars", "blocks", "playdoo" };
            List<string> ToyTypesList = new List<string>(ToyTypes);
            ToyTypesList.Add("legos");
            ToyTypesList.Add("easy bake oven");
            ToyTypesList.Add("Ninja Turtles");
            
            foreach(string Toy in ToyTypesList)
            {
                Console.WriteLine(Toy);
            }
            string[] convertedArray = ToyTypesList.ToArray();
                        
        }
    }
}
