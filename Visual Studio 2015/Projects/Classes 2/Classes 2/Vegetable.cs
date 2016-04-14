using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_2
{
    partial class Vegetables
    {//properties can intialize the values right next to properties example "purple"
     //"virtual" another modifier can override the property 
        public virtual string Type { get; set; }
        public string Color { get; set; } 
        public string Shape { get; set; }
        public string Size { get; set; }
        public string Sweetness { get; set; }

        //defualt contructor\
        public Vegetables()
        {
            Console.WriteLine("In vegetable contrsutor. ");


            this.Color = "green";
            this.Type = "cucumber";
            this.Shape = "square";
            this.Sweetness = "sweet";
            this.Size = "large";

        }
        
         
        }
    }

