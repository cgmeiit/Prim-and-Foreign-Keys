using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicatioTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User input the number of the first side of the triangle");
            double Side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("User input the number of the second side of the the triangle");
            double Side2 = double.Parse(Console.ReadLine());
            Console.WriteLine("input the angles degree");
            double Angle = double.Parse(Console.ReadLine());

            if (Angle==90)
            {
                Console.WriteLine("The first triangle is" + TriangleArea1(Side1, Side2));
                   
            }
            else
            {
                Console.WriteLine("The second triangle is" + TriangleArea2(Side1, Side2,Angle));

            }

            //triangle 1
            Console.WriteLine("The area of triangle 1 is " + TriangleArea1(7, 4));
            //triangle 2
            Console.WriteLine("The area of triangle 2 is " + TriangleArea2(24, 32, 27));
        }
        static double TriangleArea1(double sideOne, double sideTwo)
        {
            double result = sideOne * sideTwo / 2;
            return result;
        }
        static int TriangleArea2(double SideOne, double sideTwo, double Angle)
        {
            double newAngle = ConvertToRadians(Angle);
            int result = Convert.ToInt32(Math.Ceiling(SideOne * sideTwo * Math.Sin(newAngle)));
            return result;
        }
        static double ConvertToRadians(double incomingAngle)
        {
            double radians = (Math.PI / 180) * incomingAngle;
            return radians;
        }
     }
}
