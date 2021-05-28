using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    public class Bread : Product
    {
        public Bread() {}
        public Bread(string name)
            : base($"Bread {name}")
        {}
    }
}
