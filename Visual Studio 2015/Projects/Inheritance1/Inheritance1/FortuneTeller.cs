using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class FortuneTeller
    {
        //properties
        public string Name { get; set; } = "Esmerelda";
        public string ExperienceLevel { get; set; }

        //methods
        public void Greet()
        {
            Console.WriteLine("Hell Welcome to the your future");
            Console.WriteLine("Let look into your future");

        }

        public void StartService(service service)
        {
            Console.WriteLine("For you, my {0}! Yes, perfect. It only costs {1} and that's fine by everyone.", service.Name, service.Price);

        }
        public void Farewell()
        {
            Console.WriteLine("Thank you for your patronage.");
        }
        //constructors
        public FortuneTeller(string name, string experienceLevel)
        {
            this.Name = name;
            this.ExperienceLevel = experienceLevel;
        }

        public FortuneTeller()
        {
        }

    }
}
