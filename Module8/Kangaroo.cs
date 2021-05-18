using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    public class Kangaroo : Animal
    {
        public Kangaroo(string name, int footNumber, bool hasMustashes)
            : base(name, footNumber, hasMustashes)
        {
        }

        public override void Voice() => Console.WriteLine("khe-khe");
        public override void Move() => Console.WriteLine("jump-jump");
        public override void IsHungry() => Console.WriteLine("I want berries");
    }
}
