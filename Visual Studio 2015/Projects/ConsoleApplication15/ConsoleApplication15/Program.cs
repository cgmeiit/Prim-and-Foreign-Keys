using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get currrent day of week.
            // Today is one of the Properties that gets the current date.
            // DayOfWeek is also a property that gets the day  of the week. But is also used as a enum that reprepsent a string 
            // DateTime 
            //DayOfWeek today = DateTime.Today.DayOfWeek;
            //Console.WriteLine(today);

            Console.WriteLine(DateTime.Now.DayOfWeek.("dddd"));// this gives the actual day printed Tuesday.

        }
    }
}
