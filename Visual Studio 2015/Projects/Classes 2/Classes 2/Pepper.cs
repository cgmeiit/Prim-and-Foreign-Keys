using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_2
{
    class Pepper:Vegetables
    {
        public new string Type { get; set; } = "pepper";

        public Pepper()
        {
            this.Color = "purple";
            this.Size = "small";
            this.Sweetness = "little";
           // this.Type = "bell pepper";            
            this.Shape = "round";


        }
    }
}
