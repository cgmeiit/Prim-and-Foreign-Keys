using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Magic:service
    {
        public virtual bool Blackmagic { get; set; }
        public virtual int PercentEffective { get; set; }
        public override string Name{ get; set; }
        protected virtual string Expertise { get; set; }

        public virtual void Work()
        {
            Console.WriteLine("Let me pull out my {0}", this.Name);
        }
        //What about a Show method for sharing the results -- showing the magical object to the user?
        public virtual void Show()
        {
            Console.WriteLine("Oh, my. The {0} told me, yes, your future.", this.Name);
            Console.WriteLine(this.Result);
        }
        public virtual void StateEffectiveness()
        {
            Console.WriteLine("In case you're wondering, this method is {2} percent effective.", this.Name, this.Result, this.PercentEffective);
        }

    }
}
