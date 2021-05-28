using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    public abstract class Product
    {
        public static string Name { get; set; }

        protected Product() { }

        protected Product(string name)
        {
            Name = name;
        }
    }
}
