using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    public class Milk : Product
    {
        public Milk() { }
        public Milk(string name)
            : base($"Milk {name}")
        { }
    }
}
