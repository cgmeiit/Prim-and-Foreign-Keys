using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_2
{
   partial class Vegetables
    { 
        //methods is an action
        public void Ripen()
        {
            this.Color = "orange";
            this.Shape = "round";
            this.Size = "large";
            this.Sweetness = "moderate";
        }
        public void Ripen(string col, string shape, string size, string sweetness)
        {
            this.Color = col;
            this.Shape = shape;
            this.Size = size;
            this.Sweetness = sweetness;
            //constructors instantiate on object 
        }
    }
}
