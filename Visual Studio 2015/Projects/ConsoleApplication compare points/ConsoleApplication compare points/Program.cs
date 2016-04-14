using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_compare_points
{
    class Program
    {
        static void Main(string[] args)

        {
            string line = "0 1 0 5";
            string[] lost = line.Split();


            //split incoming string string line (line)
            //if xXhere== Ythere  && Yhere==Ythere direction ="here"
            //Xhere==Xthere && Yhere<Ythere direction = "N"
            int xHere = int.Parse(lost[0]); //initlaizing our two XY coordinates
            int yHere = int.Parse(lost[1]);
            int xThere = int.Parse(lost[2]);
            int yThere = int.Parse(lost[3]);

            string direction = ""; //insitlaizing string we will return to Codeeval
                                   //setting string direction based on coordinate math


            if (xHere == xThere && yHere == yThere)
                direction = "here ";
            if (xHere == xThere && yHere < yThere)
                direction = "N";
            if (xHere == xThere && yHere > yThere)
                direction = "S";
            if (xHere > xThere && yHere == yThere)
                direction = "W";
            if (xHere < xThere && yHere == yThere)
                direction = "E ";
            if (xHere < xThere && yHere < yThere)
                direction = "NE";
            if (xHere < xThere && yHere > yThere)
                direction = "SE";
            if (xHere > xThere && yHere < yThere)
                direction = "NW";
            if (xHere > xThere && yHere > yThere)
                direction = "SW";
            Console.WriteLine(direction);

        }
    }
}

