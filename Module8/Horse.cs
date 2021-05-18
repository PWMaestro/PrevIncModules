using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    public class Horse : Animal
    {
        public Horse(string name, int footNumber, bool hasMustashes)
            : base(name, footNumber, hasMustashes)
        {
        }

        public override void Voice() => Console.WriteLine("i-go-go");
        public override void Move() => Console.WriteLine("top-top");
        public new void IsHungry() => Console.WriteLine("I want hay");
    }
}
