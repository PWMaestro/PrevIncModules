using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    public class Animal
    {
        private string Name { get; set; }
        private int FootNumber { get; set; }
        private bool HasMustashes { get; set; }

        public Animal(string name, int footNumber, bool hasMustashes)
        {
            this.Name = name;
            this.FootNumber = footNumber;
            this.HasMustashes = hasMustashes;
        }

        public virtual void Voice() => Console.WriteLine("voice");
        public virtual void Move() => Console.WriteLine("movement");
        public virtual void IsHungry() => Console.WriteLine("not hungry");
    }
}
