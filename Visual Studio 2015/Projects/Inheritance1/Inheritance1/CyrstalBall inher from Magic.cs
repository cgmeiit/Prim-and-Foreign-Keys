using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class CyrstalBall:Magic
    {
        private Random random = new Random();
        
        public List<string> Phrases { get; set; }
        public override string Name { get; set; } = "Crystal Ball";


        public override void Work()
        {
            base.Work();
            this.Result = GetPhrase();
        }
        public void CreatePhrases()
        {
            Phrases.Add("Night time is a dark place for you");
            Phrases.Add("I see shiny objects in your near future");
            Phrases.Add("The decoratin around you need som hlep");  
        }

        internal void CreatePhrases(string phrase)//was protected will revisit 
        {
            Phrases.Add(phrase);
        }
        private string GetPhrase()
        {
            int randomNumber = random.Next(Phrases.Count);
            return Phrases.ElementAt(randomNumber);

        }
        public CyrstalBall()
        {
            this.Price = 45.00M;
            this.PercentEffective = 65;
            this.Blackmagic = false;
            this.Expertise = "beginner";

            CreatePhrases();

        }
    }
}
