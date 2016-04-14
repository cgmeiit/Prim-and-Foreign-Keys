using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            Animal betterCat = new Animal("cat", 6);
            Animal ozzTheCat = new Animal(true, 20);
            Console.WriteLine(cat.Legs);
            Console.WriteLine(betterCat.Species);
            Console.WriteLine(ozzTheCat.Tail);

        }
    }
    class Animal
    {
        //fields
        private int legs=4;
        private string species = "unknown";
        private string color = "purple";
        private bool tail = true;
        private int claws = 20;

        //propeties has bodies {}
        public int Legs
        //in properties use GET allows the user to retrieve the data
        {
            get { return this.legs; }

            set { this.legs = value; }
        }
        public string Species
        {
            get { return this.species;}

            set { this.species = value; } 
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public bool Tail
        {
            get { return this.tail; }
            set { this.tail = value; }
        }
        public int Claws
        {
            get { return this.claws; }
            set { this.claws = value; }
        }

        public Animal()
        {

        }
        public Animal(string tempspecies, int templegs)
        {
            this.species = tempspecies;
            this.legs = templegs;
        }
        public Animal(bool temptail, int tempclaws)
        {
            this.tail = temptail;
            this.claws = tempclaws;

        }
    }
}





