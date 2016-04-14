using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationDumbo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal dumbo = new Animal("Elephant", 4, new List<string> { "bananas", "grass" }, true);
            //dumbo.Feed();
            //dumbo.AddFavoriteFood("apples");
            //dumbo.AddFavoriteFood("celery");
            //dumbo.ListFavoriteFood();
            //dumbo.Exercise();
            Console.WriteLine("What type of species");
            string species = Console.ReadLine();
            Console.WriteLine("What food do you want to feed your animal");
            string userFood1 = Console.ReadLine();
            List<string> foods = new List<string>();
            foods.Add(userFood1);     

            Console.WriteLine("How many legs does your animal have");
            int legs =int.Parse( Console.ReadLine());
            Console.WriteLine("Does your animal have a tail?");   
            bool hasTail = bool.Parse(Console.ReadLine());
            Animal userAnimal = new Animal(species, legs, foods, hasTail);

             

        }
    }
    class Animal
    {
        //fields
        private int legs = 4;
        private string species = "unkown";
        private List<string> favoriteFood = new List<string>();
        private bool hasTail = true;
        private int hunger = 10;
        private const int maxFull = 10;
        

        //Properties
        public int Legs
        {
            get { return this.legs; }
            set { this.legs = value; }
        }

        public string Species
        {
            get { return this.species; }
            set { this.species = value; }
        }
        public List<string> FavoriteFood
        {
            get { return this.favoriteFood; }
            set { this.favoriteFood = value; }
        }

        public bool HasTail
        {
            get { return this.hasTail; }
            set { this.hasTail = value; }
        }

        public int Hunger
        {
            get { return this.hunger; }
            set
            {
                if (value >= maxFull)
                {
                    Console.WriteLine(this.Species + "is full.");
                }
              
                    this.hunger = System.Math.Min(value, maxFull);
                
            }

        }
        //Methods
        public void Exercise()
        {
             this.Hunger--;

        }

        public bool Feed()
        {
            Random random = new Random();
            int randomNum = random.Next(this.FavoriteFood.Count);
            Console.WriteLine(this.Species + "just ate"+this.FavoriteFood.ElementAt(randomNum));
            return true;
        }

        public int CheckFoodValue(string fooditem)
        {
            return 1;
        }
        internal void AddFavoriteFood(string fooditem)
        {
            this.FavoriteFood.Add(fooditem);
        }
        public void ListFavoriteFood()
        {
            Console.WriteLine(this.Species + "favorite foods include.");
            foreach (string favFood in this.FavoriteFood)
            {
                Console.WriteLine(favFood);
            }
                    
        }

        //constructors

        public Animal()
        {

        }
        public Animal(string animalSpecies, int legs, List<string> food, bool hasTail)
        {
            this.Species = animalSpecies;
            this.Legs = legs;
            this.HasTail = hasTail;
            this.FavoriteFood = food;


        }
    }
}





