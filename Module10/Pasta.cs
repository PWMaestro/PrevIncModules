using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    public class Pasta : Product
    {
        public Pasta() { }
        public Pasta(string name)
            : base($"Pasta {name}")
        { }
    }
}
