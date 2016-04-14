using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vegetables peppy = new Vegetables();
            peppy.Ripen();
            peppy.Color = "purple";
            Console.WriteLine("Peppy's color is:{0}",peppy.Color);

            Vegetables miguel = new Vegetables();
            miguel.Ripen("blue","square","small","bitter");
            Console.WriteLine("Miguel's color is:{0} Shape is {1}.Size is {2}.Sweetness is {3}",miguel.Color,miguel.Shape,miguel.Size,miguel.Sweetness);
            //Now I'm testing inheritence
            //create new pepper object 
            Pepper piper = new Pepper();
            //piper.Ripen();
            Console.WriteLine("pipers color is:{0} Shape:{1}. Size:{2}. Sweetness:{3}.Type:{4}", piper.Color, piper.Shape, piper.Size, piper.Sweetness,piper.Type);
            //create pumpkin
            Pumpkin peter = new Pumpkin();
            Console.WriteLine("peter color is:{0} Shape:{1}. Size:{2}. Sweetness:{3}.Type:{4}", peter.Color, peter.Shape, peter.Size, peter.Sweetness, peter.Type);


            //instantiated a new opbject which inherited the vegetable class. 
        }
    }

    
}

