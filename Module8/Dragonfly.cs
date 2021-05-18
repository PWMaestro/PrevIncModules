using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    public class Dragonfly : Animal
    {
        public Dragonfly(string name, int footNumber, bool hasMustashes)
            : base(name, footNumber, hasMustashes)
        {
        }

        public override void Voice() => Console.WriteLine("bj-w-w");
        public override void Move() => Console.WriteLine("flight");
        public new void IsHungry() => Console.WriteLine("I want insects");
    }
}
