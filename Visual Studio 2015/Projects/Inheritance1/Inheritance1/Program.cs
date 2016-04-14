using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            FortuneTeller fortuneTeller = new FortuneTeller();
            CyrstalBall crystalBall = new CyrstalBall();
            fortuneTeller.Greet();
            fortuneTeller.StartService((service)crystalBall);
            crystalBall.Work();
            crystalBall.Show();
            crystalBall.StateEffectiveness();
            fortuneTeller.Farewell();
        }
    }
        
 }

